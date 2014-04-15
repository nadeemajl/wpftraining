using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace AttachedPropertiesCustomWPFApp.Extensibility
{
    public static class TargetElementProvider
    {
        public static void SetTargetElement(DependencyObject dependencyObject, UIElement element)
        {
            if (element != default(UIElement))
                dependencyObject.SetValue(TargetElementProperty, element);
        }

        public static UIElement GetTargetElement(DependencyObject dependencyObject)
        {
            return dependencyObject.GetValue(TargetElementProperty) as UIElement;
        }

        public static readonly DependencyProperty TargetElementProperty =
            DependencyProperty.RegisterAttached(
                "TargetElement",
                typeof(UIElement),
                typeof(TargetElementProvider),
                new PropertyMetadata(
                    default(UIElement),
                    new PropertyChangedCallback(HandleTargetElementChanged)));

        public static void HandleTargetElementChanged(
            DependencyObject dependencyObject, DependencyPropertyChangedEventArgs eventArgs)
        {
            var sourceTextBox = dependencyObject as TextBox;

            if (sourceTextBox != default(TextBox))
            {
                var targetElement = sourceTextBox.GetValue(TargetElementProperty) as UIElement;

                targetElement.IsEnabled = default(bool);

                sourceTextBox.TextChanged += (sender, args) =>
                {
                    var targetUIElement = sourceTextBox.GetValue(TargetElementProperty) as UIElement;

                    targetUIElement.IsEnabled = sourceTextBox.Text.Length >= MIN_CHARACTERS;
                };
            }
        }

        private const int MIN_CHARACTERS = 5;
    }
}
