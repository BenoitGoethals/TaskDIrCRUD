using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskDIrCRUD
{
    public class Creator
    {
        //private const string root = "c:/temp/test";
        private  Random random = new Random();
        
      
      

      

        public void CreateFolders(string root, int start, int end, int deepth)
        {
            string path = root;


            if (deepth <= 0)
            {
                return;
            }
            for (int i = start; i < end; i++)
            {

                var word = getWord();
               
                if (path.Length >= 240)
                    return;
                path += word + "/";
                
                Console.WriteLine(path);
              
                Console.WriteLine("creating: " + path);
                System.IO.Directory.CreateDirectory(path);
                
               CreateFolders(path, start, end, deepth - 1);

               
            }
               // path = root;
            
        }


        public void CreateFiles()
        {

        }





        public int getRandom(int start,int count)
        {
            
          
            return random.Next(0 ,count)+start;
            
        }


        public String getWord()
        {
            String ret="";
            for (int i = 1;  i<getRandom(2,2); i++)
            {
                ret += (char)getRandom(65,22);
            }
            return ret;
        }

        public int Fractional(int nbr)
        {
            Console.WriteLine(nbr);
            if (nbr <= 2)
                return 1;
           return Fractional(nbr - 1)+ Fractional(nbr - 2);
        }

         decimal Factorial(int n)
        { // The bottom of the recursion 
            if (n == 0) { return 1; }
            // Recursive call: the method calls itself
            else { return n * Factorial(n - 1); } }

        }
    }
