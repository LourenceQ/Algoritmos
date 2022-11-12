/*
71. Simplify Path
Medium

Given a string path, which is an absolute path (starting with a slash '/') to a file 
or directory in a Unix-style file system, convert it to the simplified canonical path.

In a Unix-style file system, a period '.' refers to the current directory, a double 
period '..' refers to the directory up a level, and any multiple consecutive 
slashes (i.e. '//') are treated as a single slash '/'. For this problem, any other 
format of periods such as '...' are treated as file/directory names.

The canonical path should have the following format:

The path starts with a single slash '/'.
Any two directories are separated by a single slash '/'.
The path does not end with a trailing '/'.
The path only contains the directories on the path from the root directory to the target 
file or directory (i.e., no period '.' or double period '..')
Return the simplified canonical path.

Example 1:

Input: path = "/home/"
Output: "/home"
Explanation: Note that there is no trailing slash after the last directory name.
Example 2:

Input: path = "/../"
Output: "/"
Explanation: Going one level up from the root directory is a no-op, as the root level 
is the highest level you can go.
Example 3:

Input: path = "/home//foo/"
Output: "/home/foo"
Explanation: In the canonical path, multiple consecutive slashes are replaced 
by a single one. 

Constraints:

1 <= path.length <= 3000
path consists of English letters, digits, period '.', slash '/' or '_'.
path is a valid absolute Unix path.
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace SimplifyPath
{
    class Program
    {
        static void Main(string[] args)
        {
            var Input = "/home//foo/";
            var res = SimplifyPathMethod2(Input);
            Console.WriteLine(res);
        }

        public static string SimplifyPathMethod(string path)
        {
            string[] parts = path.Split('/');
            List<string> segments = new List<string>();

            for (int x = 0; x < parts.Length; x++)
            {
                if (string.IsNullOrEmpty(parts[x]) || parts[x] == ".")
                {
                    continue;
                }

                if (parts[x] == "..")
                {
                    if (segments.Count > 0)
                    {
                        segments.RemoveAt(segments.Count - 1);
                    }
                }
                else
                {
                    segments.Add(parts[x]);
                }
            }

            StringBuilder sb = new StringBuilder();
            foreach (var segment in segments)
            {
                sb.Append("/" + segment);
            }

            if(sb.Length == 0)
                sb.Append("/");


            return sb.ToString();
        }

        public static string SimplifyPathMethod2(string path)
        {
            var slash = "/";
            if(string.IsNullOrEmpty(path))
                return path;

                var dirs = path.Split(slash);
                var dirList = new List<string>();

                foreach (var dir in dirs)
                {
                    if(dir.Equals(".."))
                    {
                        if(dirList.Count > 0)
                        {
                            dirList.RemoveAt(dirList.Count - 1);
                        }
                    }
                    else if(!string.IsNullOrEmpty(dir))
                    {
                        if(!dir.Equals("."))
                        {
                            dirList.Add(dir);
                        }
                    }
                }

                return slash + string.Join(slash, dirList);
        }
    }
}
