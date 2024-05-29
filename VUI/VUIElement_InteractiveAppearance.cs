using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VUI
{
    public partial class VUIElement : IVUIElement
    {
        private string mouseEnter_BackgroundColor = "unset";
        /// <summary>
        /// Gets and sets the Background-Color that is applied when 
        /// the mouse enters the component's area.
        /// </summary>
        [Parameter]
        public string MouseEnter_BackgroundColor
        {
            get => mouseEnter_BackgroundColor;
            set { mouseEnter_BackgroundColor = value; }
        }

        private string mouseLeave_BackgroundColor = "unset";
        [Parameter]
        public string MouseLeave_BackgroundColor
        {
            get => mouseLeave_BackgroundColor;
            set { mouseLeave_BackgroundColor = value; }
        }

        private string mouseDown_BackgroundColor = "unset";
        [Parameter]
        public string MouseDown_BackgroundColor
        {
            get => mouseDown_BackgroundColor;
            set { mouseDown_BackgroundColor = value; }
        }

        private string mouseUp_BackgroundColor = "unset";
        [Parameter]
        public string MouseUp_BackgroundColor
        {
            get => mouseUp_BackgroundColor;
            set { mouseUp_BackgroundColor = value; }
        }


        private string normal_BackgroundColor = "unset";
        /// <summary>
        /// Gets and sets the Background-Color that is applied when
        /// nothing happens on the component's area.
        /// </summary>
        [Parameter]
        public string Normal_BackgroundColor
        {
            get => normal_BackgroundColor;
            set { normal_BackgroundColor = value; }
        }


        private string clicked_BackgroundColor = "unset";
        [Parameter]
        public string Clicked_BackgroundColor
        {
            get => clicked_BackgroundColor;
            set { clicked_BackgroundColor = value; }
        }

        private string toggled_BackgroundColor = "unset";
        [Parameter]
        public string Toggled_BackgroundColor
        {
            get => toggled_BackgroundColor;
            set { toggled_BackgroundColor = value; }
        }


        private string mouseEnter_Color = "unset";
        /// <summary>
        /// Gets and sets the Color that is applied when 
        /// the mouse enters the component's area.
        /// </summary>
        [Parameter]
        public string MouseEnter_Color
        {
            get => mouseEnter_Color;
            set { mouseEnter_Color = value; }
        }

        private string mouseLeave_Color = "unset";
        [Parameter]
        public string MouseLeave_Color
        {
            get => mouseLeave_Color;
            set { mouseLeave_Color = value; }
        }

        private string mouseDown_Color = "unset";
        [Parameter]
        public string MouseDown_Color
        {
            get => mouseDown_Color;
            set { mouseDown_Color = value; }
        }

        private string mouseUp_Color = "unset";
        [Parameter]
        public string MouseUp_Color
        {
            get => mouseUp_Color;
            set { mouseUp_Color = value; }
        }


        private string normal_Color = "unset";
        /// <summary>
        /// Gets and sets the Color that is applied when
        /// nothing happens on the component's area.
        /// </summary>
        [Parameter]
        public string Normal_Color
        {
            get => normal_Color;
            set { normal_Color = value;}
        }


        private string clicked_Color = "unset";
        [Parameter]
        public string Clicked_Color
        {
            get => clicked_Color;
            set { clicked_Color = value; }
        }

        private string toggled_Color = "unset";
        [Parameter]
        public string Toggled_Color
        {
            get => toggled_Color;
            set { toggled_Color = value; }
        }
    }
}
