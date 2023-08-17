﻿partial class Program
{
    class Update
    {
        private int no;
        private string title;

        public Update(int no, string title)
        {
            this.no = no;
            this.title = title;
        }
        public override string ToString()
        {
            return $"{no} - {title}";  // 1 - security update 
        }
    }
}