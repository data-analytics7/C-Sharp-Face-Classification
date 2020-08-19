using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;


namespace FaceRecognition
{
    public partial class Form1 : Form
    {
        Vector<float> NormalizedTestImgVector = Vector<float>.Build.Dense(900); //Normalized Test image vector

        Vector<float> BetaVector = Vector<float>.Build.Dense(5);    //Final value beta value

         List<double> DistanceList = new List<double>(); //List that contains Euclidean distance values
        

        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

        }


        private void TestImageBox_Click(object sender, EventArgs e)
        {
        }

        private void TrainImageBox_Click(object sender, EventArgs e)
        {

        }

        //Generates a random Test image on clicking the TestButton
        private void TestButton_Click(object sender, EventArgs e)
        {
            string[] dirs = Directory.GetDirectories("../../FaceDatasetJPG", "s*", SearchOption.TopDirectoryOnly);  //reads in all 40 folder names

            Random rnd = new Random();
            int randomTestingImg = rnd.Next(6, 10); //Selects a random image between 6 and 10 in a class
            int randomDir = rnd.Next(0, 40);    //Selects a random Image class between 1 and 40

            Image testImg = Image.FromFile(dirs[randomDir] + "/" + randomTestingImg + ".jpg");  //Reads a random image from a random class

            Bitmap resized = new Bitmap(testImg, new Size(30, 30)); //Resizing the image

            List<float> ImgList = new List<float>();
            ImgList = GetNormalizedImg(resized);    //Stores Normalized image in a list
            float[] testImgArray = ImgList.ToArray();   //creating 'y' to use in Beta formula
            NormalizedTestImgVector = GetNormalizedTestVector(testImgArray);    //returns Normalized test image vector

            TestImageBox.Image = testImg;   //Displaying the randomly selected test image

        }

        //Trains and displays the matching image 
        private void TrainButton_Click(object sender, EventArgs e)
        {
            string[] dirs = Directory.GetDirectories("../../FaceDatasetJPG", "s*", SearchOption.TopDirectoryOnly);  //reads all 40 folder names in

            List<List<float>> ClassList = new List<List<float>>();  //Storing 5 image lists from each class into this List            

            foreach (string imgs in dirs)    //folder name one by one --- for each image in the folder
            {              
                string[] CurrentImgFolder = Directory.GetFiles(imgs + "/" , "*jpg");    //stores all 10 image name from each folder
                
                int counter = 0;    //keeping count of number of images from each folder-- Restricting to 5!

                if (ClassList.Count() == 5) //To read only 5 images from each class
                {
                    float[][] ClassArray = ClassList.Select(a => a.ToArray()).ToArray();    //Converting List to Jagged array

                    float[,] ClassArray2d = ConvertTo2dArray(ClassArray);   //Converting Jagged array to 2d-array

                    CalcBeta(ClassArray2d);   //Calculating final Beta value

                    ClassList.Clear(); //Clearing the ClassList, to accomadate 5 training images from next class

                    Array.Clear(ClassArray, 0, ClassArray.Length);  //Clearing ClassArray
               
                }


                foreach (string CurrentImg in CurrentImgFolder) //For each image in the current class
                {
                    
                    while (counter < 5)
                    {
                        Image original = Image.FromFile(CurrentImgFolder[counter]); //Reading an image
                        Bitmap resized = new Bitmap(original, new Size(30, 30));    //Resizing the image
                        
                        List<float> ImgList = new List<float>();
                    
                        ImgList = new List<float> (GetNormalizedImg(resized));  //Storing Normalized image in a List
                        
                        ClassList.Add(new List<float>(ImgList));    //Storing each normalized image in a ClassList
                        ImgList.Clear();

                        counter++;  //counting number of images read form each folder
                    }                                       
                }
            }

            var min_Distance_index = GetMinDistance();  //Getting the index of the image that has the least Euclidean distance value

            for (int i=1; i<=5; i++)    //Displaying Training images using a loop
            {
                switch(i)
                {
                    case 1: ListBox1.Image = Image.FromFile(dirs[min_Distance_index] + @"\1.jpg");
                        break;

                    case 2:
                        ListBox2.Image = Image.FromFile(dirs[min_Distance_index] + @"\2.jpg");
                        break;

                    case 3:
                        ListBox3.Image = Image.FromFile(dirs[min_Distance_index] + @"\3.jpg");
                        break;

                    case 4:
                        ListBox4.Image = Image.FromFile(dirs[min_Distance_index] + @"\4.jpg");
                        break;

                    default:
                        ListBox5.Image = Image.FromFile(dirs[min_Distance_index] + @"\5.jpg");
                        break;
                        
                }

            }

            Random rnd = new Random();
            int randomTrainingImg = rnd.Next(1, 5); 

            TrainImageBox.Image = Image.FromFile(dirs[min_Distance_index]+ @"\" + randomTrainingImg +".jpg");   //Displaying matching image
            MessageBox.Show("Training Complete!\n\nMatch Found!\n\nImage belongs to class: " + (dirs[min_Distance_index].Substring(dirs[min_Distance_index].IndexOf(@"\") + 1)).ToString());
            DistanceList.Clear();   //Clearing list
        }

        private void ListBox1_Click(object sender, EventArgs e)
        {

        }

        private void ListBox2_Click(object sender, EventArgs e)
        {

        }

        private void ListBox3_Click(object sender, EventArgs e)
        {

        }

        private void ListBox4_Click(object sender, EventArgs e)
        {

        }

        private void ListBox5_Click(object sender, EventArgs e)
        {

        }


        private List<float> GetNormalizedImg(Bitmap resized)   //Method to Normalize image
        {
            List<float> theList = new List<float>();
            List<float> NormalizedList = new List<float>();

            for (int i = 0; i < resized.Width; i++)
            {
                for (int j = 0; j < resized.Height; j++)
                {
                    theList.Add(resized.GetPixel(i, j).R);  //Storing pixel value in a list
                }
            }

            float max = theList.Max();

            for (int i = 0; i < theList.Count(); i++)
            {
                NormalizedList.Add((theList.ElementAt(i)) / max);   //Dividing each value in the list with the max value
            }

            return NormalizedList;
        }

        private Vector<float> GetNormalizedTestVector(float[] arr)  //Return normliazed image vector
        {
            var V = Vector<float>.Build;
            var v = V.DenseOfArray(arr);

            return v;
        }

        int Betacounter = 1;
        private void CalcBeta(float[,] ClassArray2d)
        {         
            var M = Matrix<float>.Build;
            var ClassMatrix = M.DenseOfArray(ClassArray2d);

            BetaVector = ((ClassMatrix.Transpose() * ClassMatrix).Inverse()) * (ClassMatrix.Transpose() * NormalizedTestImgVector); //Computing beta value

            var Predicted_y = ClassMatrix * BetaVector;  //Computing predicted 'y' value

            var y = NormalizedTestImgVector - Predicted_y;

            var d = y.L2Norm(); //Performing L2Norm to find Euclidean distance

            DistanceList.Add(d);

            Betacounter++;
            if(Betacounter == 40)
            {
                Betacounter = 1;
            }

            BetaVector.Clear();
        }

        private int GetMinDistance()    //To get the least value of Euclidean distance in the DistanceList
        {            
            double minVal = DistanceList.Min();            
            int index = DistanceList.IndexOf(minVal);
            
            return index;
        }

        private float[,] ConvertTo2dArray(float[][] ClassArray) //Function to convert Jagged arrays to 2-d array
        {
            int w = ClassArray.GetLength(0);
            int h = 900; //according to the dimensions of our resized image (30x30)

            float[,] ClassArray2d = new float[h, w];
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    ClassArray2d[j, i] = ClassArray[i][j];
                }
            }

            return ClassArray2d;

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click_2(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }
    }
}
