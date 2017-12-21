namespace Task_03
{
    using System;
    using System.Collections.Generic;

    public class DynamicArray
    {
        public string[] Myarray;        
              
        public DynamicArray()
        {           
            string[] myarray = new string[8];           
        }

        public DynamicArray(int n)
        {            
            string[] myarray = new string[n];            
        }

        public DynamicArray(List<string> list)
        {
            string[] myarray = new string[list.Count];
            for (this.Index = 0; this.Index < list.Count; this.Index++)
            {
                this.Myarray[this.Index] = list[this.Index];
            }
        }

        public int Index { get; set; }

        public void Add(string s)
        {
            if (this.Lenght() == this.Capacity())
            {
                Array.Resize(ref this.Myarray, this.Myarray.Length * 2);
            }

            this.Index = this.Lenght() + 1;
            this.Myarray[this.Index] = s;            
        }

        public void AddAddRange(List<string> list)
        {
            Array.Resize(ref this.Myarray, this.Capacity() + list.Count);
            for (this.Index = this.Lenght(); this.Index < this.Lenght() + list.Count; this.Index++)
            {
                this.Myarray[this.Index] = list[this.Index - this.Lenght()];
            }
        }

        public void Remove(int index)
        {
            this.Myarray[index] = null;
            string temp;
            for (int i = index; i > this.Lenght(); i++)
            {
                temp = this.Myarray[i];
                this.Myarray[i] = this.Myarray[i + 1];
                this.Myarray[i + 1] = temp;
            }
        }

        public void Insert(string s, int index)
        {
            string temp;
            if (this.Lenght() == this.Capacity())
            {
                throw new ArgumentOutOfRangeException("Out of bounds of the array");
            }
            else
            {
                for (int i = this.Lenght(); i > index; i--)
                {
                    temp = this.Myarray[i - 1];
                    this.Myarray[i - 1] = this.Myarray[i];
                    this.Myarray[i] = temp;
                }

                this.Myarray[index] = s;
            }                
        }

        public int Lenght()
        {
            this.Index = 0;
            while (this.Myarray[this.Index] != null)
            {
                this.Index++;
            }

            return this.Index;
        }

        public int Capacity()
        {
            return this.Myarray.Length;
        }        
    }
}
