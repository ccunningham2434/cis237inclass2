using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass2
{
    class Hanoi
    {
        Int64 moveNum;// >The number of moves.

        public Hanoi()
        {
            moveNum = 0;
        }
        

        // >
        public void MoveDisk(int n, char source, char auxilary, char destination)
        {
            // >Base Case.
            if (n == 1)
            {
                moveNum += 1;

                // >Since we only have to move one disk. (n = 1), we don't want to make another...
                // >    ...recursive call. We just want to output the move that we are performing.
                Console.WriteLine("Move disk from tower {0} to tower {1}  -  Number of moves: " + moveNum, source, destination);
                //Console.WriteLine("Move disk from tower {0} to tower {1}", source, destination);
            } 
            else
            {
                // >Attempt to move (n - 1) disks from source location to auxilary location, using..
                // >    ...the auxilary peg as temporary storage.
                MoveDisk(n - 1, source, destination, auxilary);

                // >Move the source disk to the destination.
                MoveDisk(1, source, auxilary, destination);

                // >Move the (n - 1) from auxilary to destination using the beginning...
                // >    ...as temporary storage.
                MoveDisk(n - 1, auxilary, source, destination);
            }

        }
    }
}
