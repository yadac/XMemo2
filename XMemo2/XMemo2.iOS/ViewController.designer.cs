// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace XMemo2.iOS
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel DateLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField DateText { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton LoadButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel MemoLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView MemoTextView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton SaveButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel SubjectLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField SubjectText { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (DateLabel != null) {
                DateLabel.Dispose ();
                DateLabel = null;
            }

            if (DateText != null) {
                DateText.Dispose ();
                DateText = null;
            }

            if (LoadButton != null) {
                LoadButton.Dispose ();
                LoadButton = null;
            }

            if (MemoLabel != null) {
                MemoLabel.Dispose ();
                MemoLabel = null;
            }

            if (MemoTextView != null) {
                MemoTextView.Dispose ();
                MemoTextView = null;
            }

            if (SaveButton != null) {
                SaveButton.Dispose ();
                SaveButton = null;
            }

            if (SubjectLabel != null) {
                SubjectLabel.Dispose ();
                SubjectLabel = null;
            }

            if (SubjectText != null) {
                SubjectText.Dispose ();
                SubjectText = null;
            }
        }
    }
}