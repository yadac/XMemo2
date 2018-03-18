
using System;
using System.Drawing;

using Foundation;
using UIKit;

namespace XMemo2.iOS
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }



        #region View lifecycle

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Perform any additional setup after loading the view, typically from a nib.
            MemoHolder.Current.Memo = new Memo()
            {
                Date = DateTime.Now,
                Subject = "",
                Text = "",
            };

            DisplayMemo();

            SubjectText.EditingChanged += (s, e) => { MemoHolder.Current.Memo.Subject = SubjectText.Text; };
            MemoTextView.Changed += (s, e) => { MemoHolder.Current.Memo.Text = MemoTextView.Text;};

            SetupDatePicker();
        }

        private void SetupDatePicker()
        {
            // close button
            var doneButton = new UIBarButtonItem("close", UIBarButtonItemStyle.Done, (s, e) =>
                {
                    // Close DatePicker
                    DateText.ResignFirstResponder();
                });

            // toolbar 
            var toolbar = new UIToolbar()
            {
                BarStyle = UIBarStyle.Default,
                Translucent = true,
                TintColor = null,
            };

            // add closebutton and space on Toolbar
            toolbar.SizeToFit();
            toolbar.SetItems(new []
            {
                // space adjust , flexiblespace leads to right align for done button.
                new UIBarButtonItem(UIBarButtonSystemItem.FlexibleSpace),
                doneButton,
            },true);

            // datepicker
            var datePicker = new UIDatePicker()
            {
                Mode = UIDatePickerMode.Date,
            };

            // datepicker event
            datePicker.ValueChanged += (s, e) =>
            {
                MemoHolder.Current.Memo.Date = (DateTime) datePicker.Date;
                DisplayMemo();
            };

            // set toolbar and datepicker set
            DateText.InputAccessoryView = toolbar;
            DateText.InputView = datePicker;

        }

        private void DisplayMemo()
        {
            var memo = MemoHolder.Current.Memo;
            DateText.Text = $"{memo.Date:yyyy/MM/dd}";
            SubjectText.Text = memo.Subject;
            MemoTextView.Text = memo.Text;

        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
        }

        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);
        }

        public override void ViewDidDisappear(bool animated)
        {
            base.ViewDidDisappear(animated);
        }

        #endregion
    }
}