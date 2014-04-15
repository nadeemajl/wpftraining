using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;

namespace GS.Libraries.Extensibility
{
    public static class CommandProvider
    {
        public static ICommand GetCommand(DependencyObject dependencyObject)
        {
            return dependencyObject.GetValue(CommandProperty) as ICommand;
        }

        public static void SetCommand(DependencyObject dependencyObject, ICommand command)
        {
            dependencyObject.SetValue(CommandProperty, command);
        }

        public static readonly DependencyProperty CommandProperty =
            DependencyProperty.RegisterAttached(
                "Command",
                typeof(ICommand),
                typeof(CommandProvider),
                new PropertyMetadata(
                    default(ICommand),
                    new PropertyChangedCallback(HandleCommandChanged)));

        public static void HandleCommandChanged(
            DependencyObject dependencyObject, DependencyPropertyChangedEventArgs eventArgs)
        {
            var selector = dependencyObject as Selector;

            if (selector != default(Selector))
            {
                selector.SelectionChanged += (sender, args) =>
                {
                    var command = selector.GetValue(CommandProperty) as ICommand;
                    var commandParameter = selector.GetValue(CommandParameterProperty);

                    if (command != default(ICommand) && command.CanExecute(commandParameter))
                        command.Execute(commandParameter);
                };
            }
        }

        public static object GetCommandParameter(DependencyObject obj)
        {
            return (object)obj.GetValue(CommandParameterProperty);
        }

        public static void SetCommandParameter(DependencyObject obj, object value)
        {
            obj.SetValue(CommandParameterProperty, value);
        }

        public static readonly DependencyProperty CommandParameterProperty =
            DependencyProperty.RegisterAttached(
                "CommandParameter",
                typeof(object),
                typeof(CommandProvider),
                new PropertyMetadata(
                    default(object)));
    }
}
