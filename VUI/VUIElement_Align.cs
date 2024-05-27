using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VUI
{
    public partial class VUIElement : ComponentBase, IUIElement
    {
        string _align = "";
        string align = "unset";

        /// <summary>
        /// Determines the alignment of the UI element within its container.
        /// 
        /// The value can be one of the following:
        /// <list type="bullet">
        /// <item><description>"Itself": Aligns the element relative to its own content.</description></item>
        /// <item><description>"Children": Aligns the element relative to its child elements.</description></item>
        /// <item><description>"top-left", "top-right", "bottom-left", "bottom-right": Aligns the element to the specified corner.</description></item>
        /// <item><description>"center": Aligns the element both vertically and horizontally.</description></item>
        /// <item><description>"left-center", "right-center": Aligns the element horizontally with respect to the container.</description></item>
        /// <item><description>"top-center", "bottom-center": Aligns the element horizontally and vertically.</description></item>
        /// </list>
        /// </summary>
        [Parameter]
        public string Align
        {
            get => align;
            set { align = value;  }
        }

        public void ToAlign(string value)
        {
            Align = value;
        }

        protected virtual void onAlign()
        {
            if (_align != align)
            {
                _align = align;
                
                if (string.IsNullOrEmpty(align) ||
                    align == "none")
                {
                    Display = "inline-block";
                    Position = "absolute";
                    Top = "0";
                    Left = "0";
                    Transform = "translate(0%, 0%)";
                    return;
                }

                var settings = Align.Split(' ');

                for (int i = 0; i < settings.Length; i++)
                {
                    var setting = settings[i];

                    switch (setting)
                    {
                        case "Itself":
                            onAlign_Itself(settings, ref i);
                            break;

                        case "Children":
                            onAlign_Children(settings, ref i);
                            break;
                    }
                }

            }

        }

        private void onAlign_Children(string[] settings, ref int i)
        {
            Display = "flex";

            for (++i; i < settings.Length; i++)
            {
                switch(settings[i])
                {
                    case "top-left": 
                        
                        JustifyContent = "start";
                        AlignItems = "start";
                        break;

                    case "top-right":
                        
                        JustifyContent = "right";
                        AlignItems = "start";
                        break;

                    case "bottom-left":
                        
                        JustifyContent = "start";
                        AlignItems = "end";
                        break;

                    case "bottom-right":
                        
                        JustifyContent = "right";
                        AlignItems = "end";
                        break;


                    case "center":
                        
                        JustifyContent = "center";
                        AlignItems = "center";
                        break;


                    case "left-center":
                        
                        JustifyContent = "left";
                        AlignItems = "center";
                        break;

                    case "right-center":
                        
                        JustifyContent = "right";
                        AlignItems = "center";
                        break;

                    case "top-center":
                        
                        JustifyContent = "center";
                        AlignItems = "start";
                        break;

                    case "bottom-center":
                        
                        JustifyContent = "center";
                        AlignItems = "end";
                        break;
                }
            }
        }


        private void onAlign_Itself(string[] settings, ref int i)
        {
            Position = "absolute";

            for (++i; i < settings.Length; i++)
            {
                switch(settings[i])
                {
                    case "top-left":
                        Top = "0"; Left = "0"; 
                        Transform = "translateY(0) translateX(0)";
                        break;

                    case "top-right":
                        Top = "0"; Right = "0";
                        Transform = "translateY(0) translateX(0)";
                        break;

                    case "bottom-left":
                        Bottom = "0"; Left = "0";
                        Transform = "translateY(0) translateX(0)";
                        break;

                    case "bottom-right":
                        Bottom = "0"; Right = "0";
                        Transform = "translateY(0) translateX(0)";
                        break;


                    case "center":
                        Bottom = "50%"; Right = "50%";
                        Transform = "translate(50%, 0%)";
                        
                        break;

                    case "left-center":
                        Bottom = "50%"; Left = "0%";
                        Transform = "translate(0%, 0%)";
                        break;

                    case "right-center":
                        Bottom = "50%"; Right = "0%";
                        Transform = "translate(0%, 0%)";
                        break;

                    case "top-center":
                        Top = "0%"; Right = "50%";
                        Transform = "translate(0%, 0%)";
                        break;

                    case "bottom-center":
                        Bottom = "0%"; Right = "50%";
                        Transform = "translate(0%, 0%)";
                        break;
                }
            }
        }
    }
}
