using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VUI
{
    public interface IVUIText
    {
        string FontFamily { get; set; }
        string FontSize { get; set; }
        string FontWeight { get; set; }
    }
}
