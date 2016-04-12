namespace DevExpress.DevAV
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.CompilerServices;

    public class State
    {
        public byte[] Flag24px { get; set; }

        public byte[] Flag48px { get; set; }

        public string LongName { get; set; }

        [Key]
        public StateEnum ShortName { get; set; }
    }
}

