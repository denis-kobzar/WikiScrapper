using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WikiScrapper.Commands.Base;

namespace WikiScrapper.Commands.Window
{
    class CloseCommand : BaseCommand
    {
        public override bool CanExecute(object? parameter)
        {
            return true;
        }

        public override void Execute(object? parameter)
        {
            Application.Current.Shutdown();
        }
    }
}
