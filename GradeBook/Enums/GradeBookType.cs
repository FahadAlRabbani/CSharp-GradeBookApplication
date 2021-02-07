using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace GradeBook.Enums
{
    public enum GradeBookType
    {
        [Description("standard")]
        Standard = 0,
        [Description("ranked")]
        Ranked,
        [Description("esnu")]
        ESNU,
        [Description("onetofour")]
        OneToFour,
        [Description("sixpoint")]
        SixPoint
    }
}
