using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskDIrCRUD
{
    class Program
    {
        static void Main(string[] args)
        {

            // Make Parallel Directory + populate
            // Make XML TREE-
            // proces parallel files
        }
        /*
        private static void createAlphabetFolders(File parent, int start, int end, int deepth)
        {

            if (deepth <= 0)
            {
                return;
            }

            for (int i = start; i < end; i++)
            {

                // create the folder
                String folderName = "" + ((char)i);
                File folder = new File(parent, folderName);
                System.out.println("creating: " + folder.getPath());
                folder.mkdirs();

                // call recursively
                createAlphabetFolders(folder, start, end, deepth - 1);
            }
        }
        */

/*
 ublic static void main(String[] args) {
File root = new File("C:\\SO");
List<String> alphabet = new ArrayList<String>();
for (int i = 0; i < 26; i++) {
alphabet.add(String.valueOf((char)('a' + i)));
}

final int depth = 3;
mkDirs(root, alphabet, depth);
}

public static void mkDirs(File root, List<String> dirs, int depth) {
if (depth == 0) return;
for (String s : dirs) {
File subdir = new File(root, s);
subdir.mkdir();
mkDirs(subdir, dirs, depth - 1);
}
}*/
}
}
