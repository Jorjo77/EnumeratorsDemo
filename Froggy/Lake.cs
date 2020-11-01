using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Froggy
{
    public class Lake : IEnumerable<int>
    {
        private readonly int[] stones;//такива референтни типове често се правят рийдонли за да не могат да бъдат променяни
        public Lake(params int[] stones)
        {
            this.stones = stones;
        }

        public IEnumerator<int> GetEnumerator()
        {
            //implement custom iteration logic
            for (int i = 0; i < this.stones.Length -1; i += 2)
            {
                yield return this.stones[i];
            }
            for (int i = this.stones.Length - 1; i > 0; i--)
            {
                if (i % 2 != 0)
                {
                    //index is odd
                    yield return this.stones[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
