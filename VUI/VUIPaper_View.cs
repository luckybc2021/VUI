using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VUI
{
    public partial class VUIPaper<TPiece> : VUIElement
    {
        private readonly string[] view = ["single", "", ""];

        private string _view = "single";
        [Parameter]
        public string View
        {
            get => _view;
            set
            {
                _view = value;
            }
        }

        private void Handle_View()
        {
            var parts = View.Split(' ',
                StringSplitOptions.RemoveEmptyEntries);

            switch (parts.Length)
            {
                case 1:
                    
                    One(parts);

                    Display = "block";
                    FlexFlow = "unset";
                    Width = "100vw";
                    Height = "100vh";
                    break;

                case 2:

                    One(parts);
                    Two(parts);

                    Display = "inline-block";
                    FlexFlow = "unset";
                    Width = "100vw";
                    Height = "100vh";
                    break;

                case 3:
                case 5:

                    One(parts);
                    Two(parts);
                    Three(parts);
                    break;
            }
        }

        private void One(string[] parts)
        {
            switch (parts[0])
            {
                case "dual":

                    view[0] = "dual";
                    view[1] = "vertical-fit";
                    view[2] = "vertical-fit";

                    break;

                case "single":
                default:

                    View = "single";
                    view[0] = "single";
                    view[1] = "";
                    view[2] = "";
                    break;
            }
        }

        private void Two(string[] parts)
        {
            switch (parts[1])
            {
                case "horizontal":
                    
                    view[1] = "horizontal-fit";
                    view[2] = "horizontal-fit";

                    break;

                default:

                    View = "dual vertical fit";
                    break;
            }
        }

        private void Three(string[] parts)
        {
            switch (parts[1])
            {
                case "horizontal":

                    Sides_Horizontal(parts);

                    break;

                default:

                    Sides_Vertical(parts);
                    break;
            }            
        }

        private void Sides_Horizontal(string[] parts)
        {
            switch (parts[2])
            {
                case "custom":
                    view[1] = "horizontal-custom1";
                    widthMaxContent1 = parts[3];

                    view[2] = "horizontal-custom2";
                    widthMaxContent2 = parts[4];

                    Display = "inline-flex";
                    FlexFlow = "row";
                    Width = "100vw";
                    Height = "100vh";
                    break;

                case "max":

                    view[1] = "horizontal-max";
                    view[2] = "horizontal-max";

                    Display = "inline-flex";
                    FlexFlow = "row";
                    Width = "max-content";
                    Height = "100vh";
                    break;

                case "normal":

                    view[1] = "horizontal-normal";
                    view[2] = "horizontal-normal";

                    Display = "inline-flex";
                    FlexFlow = "column";
                    Width = "100vw";
                    Height = "100vh";
                    break;

                default :

                    view[1] = "horizontal-fit";
                    view[2] = "horizontal-fit";

                    Display = "inline-block";
                    FlexFlow = "unset";
                    Width = "100vw";
                    Height = "100vh";
                    break;
            }
        }

        private void Sides_Vertical(string[] parts)
        {
            switch (parts[2])
            {
                case "custom":
                    view[1] = "vertical-custom1";
                    widthMaxContent1 = parts[3];

                    view[2] = "vertical-custom2";
                    widthMaxContent2 = parts[4];

                    Display = "inline-flex";
                    FlexFlow = "row";
                    Width = "100vw";
                    Height = "100rh";
                    break;

                case "max":

                    view[1] = "vertical-max";
                    view[2] = "vertical-max";

                    Display = "block";
                    FlexFlow = "unset";
                    Width = "100vw";
                    Height = "max-content";
                    break;

                case "normal":

                    view[1] = "vertical-normal";
                    view[2] = "vertical-normal";

                    Display = "inline-block";
                    FlexFlow = "unset";
                    Width = "100vw";
                    Height = "100vh";
                    break;

                default:
                    view[1] = "vertical-fit";
                    view[2] = "vertical-fit";

                    Display = "block";
                    FlexFlow = "unset";
                    Width = "100vw";
                    Height = "100vh";
                    break;
            }
        }
    }
}
