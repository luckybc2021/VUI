﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.TimeZoneInfo;

namespace VUI
{
    public static class VUITransitionManager
    {
        internal static void Handle(VUIElement e)
        {
            switch (e.TransitionType)
            {
                case "UIState":

                    Handle_UIState(e);
                    break;

                case "UserDecision":

                    Handle_UserDecision(e);
                    break;
            }
        }

        private static void Handle_UIState(VUIElement e)
        {
            switch (e.Transition)
            {
                case "Color":

                    switch (e.InteractionState + "_BackgroundColor")
                    {
                        case "MouseLeave_BackgroundColor":
                        case "Normal_BackgroundColor":
                            e.SetBackgroundColor(e.Normal_BackgroundColor);
                            break;
                        
                        case "MouseDown_BackgroundColor":
                            e.SetBackgroundColor(e.Clicked_BackgroundColor);
                            break;

                        case "MouseUp_BackgroundColor":
                        case "MouseEnter_BackgroundColor":
                            e.SetBackgroundColor(e.MouseEnter_BackgroundColor);
                            break;
                    }

                    switch (e.InteractionState + "_Color")
                    {
                        case "MouseLeave_Color":
                        case "Normal_Color":
                            e.SetColor(e.Normal_Color);
                            break;

                        case "MouseDown_Color":
                            e.SetColor(e.Clicked_Color);
                            break;

                        case "MouseUp_Color":
                        case "MouseEnter_Color":
                            e.SetColor(e.MouseEnter_Color);
                            break;
                    }

                    break;
            }
        }

        private static void Handle_UserDecision(VUIElement e)
        {
            switch (e.Transition)
            {
                case "Color":

                    switch (e.InteractionState + "_BackgroundColor")
                    {
                        case "Normal_BackgroundColor":
                            e.SetBackgroundColor(e.Normal_BackgroundColor);
                            break;

                        case "Clicked_BackgroundColor":
                            e.SetBackgroundColor(e.Clicked_BackgroundColor);
                            break;

                        case "MouseLeave_BackgroundColor":
                            e.SetBackgroundColor(e.MouseLeave_BackgroundColor);
                            break;

                        case "MouseEnter_BackgroundColor":
                            e.SetBackgroundColor(e.MouseEnter_BackgroundColor);
                            break;

                        case "MouseDown_BackgroundColor":
                            e.SetBackgroundColor(e.MouseDown_BackgroundColor);
                            break;

                        case "MouseUp_BackgroundColor":
                            e.SetBackgroundColor(e.MouseUp_BackgroundColor);
                            break;
                    }

                    switch (e.InteractionState + "_Color")
                    {
                        case "Normal_Color":
                            e.SetColor(e.Normal_Color);
                            break;

                        case "Clicked_Color":
                            e.SetColor(e.Clicked_Color);
                            break;

                        case "MouseLeave_Color":
                            e.SetColor(e.MouseLeave_Color);
                            break;

                        case "MouseEnter_Color":
                            e.SetColor(e.MouseEnter_Color);
                            break;

                        case "MouseDown_Color":
                            e.SetColor(e.MouseDown_Color);
                            break;

                        case "MouseUp_Color":
                            e.SetColor(e.MouseUp_Color);
                            break;
                    }
                    break;
            }
        }

        /// <summary>
        /// Transitions the UI element to a specified interaction state 
        /// with optional delays and skipping certain states.
        /// </summary>
        /// <param name="e">The UI element that will be transitioned to a new InteractionState. 
        /// The TransitionManager's Handle function will be invoked for this element.</param>
        /// <param name="msDelayBefore">The delay in milliseconds before 
        /// the transition.</param>
        /// <param name="_interactionState">The interaction state to 
        /// transition to.</param>
        /// <param name="msDelayAfter">The delay in milliseconds after 
        /// the transition.</param>
        /// <param name="skipTransitionStates">The states to be 
        /// skipped during the transition.</param>
        /// <returns>A Task representing the asynchronous operation.</returns>
        public static async Task TransitionTo(VUIElement e, int msDelayBefore, string _interactionState, int msDelayAfter,
            string[] skipTransitionStates)
        {
            switch (e.TransitionType)
            {
                case "UIState":

                    break;

                case "UserDecision":

                    e.SetSkipTransitionStates(skipTransitionStates);

                    await Task.Delay(msDelayBefore);
                    e.InteractionState = _interactionState;

                    VUITransitionManager.Handle(e);

                    // Only re-render the VUIElement
                    //
                    if (e.InteractionState == "Normal")
                    {
                        e.ReRender();
                    }
                    
                    await Task.Delay(msDelayAfter);

                    break;
            }
        }

        /// <summary>
        /// The VUIElement will be changed,
        /// <list type="bullet">
        /// <item>
        /// <description>"InteractionState": Normal</description>
        /// </item>
        /// <item>
        /// <description>"ReRender()": called</description>
        /// </item>
        /// <item>
        /// <description>"SetSkipTransitionStates([])": called</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="e"></param>
        public static void StopTransition(VUIElement e)
        {
            e.InteractionState = "Normal";
            e.ReRender();

            e.SetSkipTransitionStates([]);
        }
    }
}
