using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VUI
{
    public interface IUIElement
    {
        //
        // Define the properties that all UI elements should have
        //

        string ID { get; set; }


        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <description>"None": the UIElement contains nothing.</description>
        /// </item>
        /// <item>
        /// <description>"Text": the UIElement contains text content.</description>
        /// </item>
        /// <item>
        /// <description>"Image": the UIElement displays an image.</description>
        /// </item>
        /// <item>
        /// <description>"Video": the UIElement plays a video.</description>
        /// </item>
        /// <item>
        /// <description>"Audio": the UIElement plays an audio file.</description>
        /// </item>
        /// </list>
        /// </summary>
        string ContentType { get; set; }


        /// <summary>
        /// Gets or sets the path to the content file. 
        /// This property is used for various content types 
        /// such as music, video, images, etc.
        /// The value should be a valid file path pointing to the content file.
        /// </summary>
        string Path { get; set; }


        string MouseEnter_BackgroundColor { get; set; }
        string MouseLeave_BackgroundColor { get; set; }
        string MouseDown_BackgroundColor { get; set; }
        string MouseUp_BackgroundColor { get; set; }

        string Normal_BackgroundColor { get; set; }
        string Clicked_BackgroundColor { get; set; }
        string Toggled_BackgroundColor { get; set; }

        string BackgroundColor { get; set; }


        string MouseEnter_Color { get; set; }
        string MouseLeave_Color { get; set; }
        string MouseDown_Color { get; set; }
        string MouseUp_Color { get; set; }

        string Normal_Color { get; set; }
        string Clicked_Color { get; set; }
        string Toggled_Color { get; set; }

        string Color { get; set; }



        /// <summary>
        /// Represents the transition of an element, 
        /// which can be either a UI or non-UI element. 
        /// The possible transitions include:
        /// <list type="bullet">
        /// 
        /// <item>
        /// <description>"None": No action is triggered when 
        /// the UI element changes state.</description>
        /// </item>
        /// 
        /// <item>
        /// <description>"Color": A change in the foreground and 
        /// background colors to match the target state is triggered when 
        /// the UI element changes state.</description>
        /// </item>
        /// 
        /// <item>
        /// <description>"PlaybackRate": the current playback speed of 
        /// the audio/video.</description>
        /// </item>
        /// 
        /// </list>
        /// </summary>
        string Transition { get; set; }


        /// <summary>
        /// Represents the transition type of a UI element. 
        /// The possible transition types are:
        /// <list type="bullet">
        /// 
        /// <item>
        /// <description>"InteractionState": This is triggered when 
        /// a state change occurs in the UI element.</description>
        /// </item>
        /// 
        /// <item>
        /// <description>"MediaState": This value is used when 
        /// a state change occurs in a Media element.
        /// </description>
        /// </item>
        /// 
        /// <item>
        /// <description>"UserDecision": This allows users to decide 
        /// the action when a state change in the UI element.</description>
        /// </item>
        /// 
        /// </list>
        /// </summary>
        string StateType { get; set; }


        /// <summary>
        /// Stores a list of interaction/transition states 
        /// that should be skipped or ignored in some process.
        /// </summary>
        string[] SkipStates { get; set; }

        string Border { get; set; }
        string Display { get; set; }
        string Width { get; set; }
        string Height { get; set; }
        string Cursor { get; set; }
        string Position { get; set; }
        string VerticalAlign { get; set; }
        string HorizontalAlign { get; set; }
        string Padding { get; set; }

        //
        // Media
        //
        double Duration { get; set; }
        double CurrentTime {  get; set; }


        //
        // Define the methods that all UI elements should implement
        //      
    }
}
