﻿#region COPYRIGHT
//
//     THIS IS GENERATED BY TEMPLATE
//     
//     AUTHOR  :     ROYE
//     DATE       :     2010
//
//     COPYRIGHT (C) 2010, TIANXIAHOTEL TECHNOLOGIES CO., LTD. ALL RIGHTS RESERVED.
//
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Reflection;


namespace SkyCar.Framework.WindowUI.Controls
{
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class CheckBoxProperties
    {
        private Appearance _Appearance = Appearance.Normal;
        private bool _AutoSize = false;
        private bool _AutoCheck = true;
        private bool _AutoEllipsis = false;
        private ContentAlignment _CheckAlign = ContentAlignment.MiddleLeft;
        private Color _FlatAppearanceBorderColor = Color.Empty;
        private int _FlatAppearanceBorderSize = 1;
        private Color _FlatAppearanceCheckedBackColor = Color.Empty;
        private Color _FlatAppearanceMouseDownBackColor = Color.Empty;
        private Color _FlatAppearanceMouseOverBackColor = Color.Empty;
        private FlatStyle _FlatStyle = FlatStyle.Standard;
        private Color _ForeColor = SystemColors.ControlText;
        private RightToLeft _RightToLeft = RightToLeft.No;
        private ContentAlignment _TextAlign = ContentAlignment.MiddleLeft;
        private bool _ThreeState = false;

        public CheckBoxProperties()
        {
        }

        public event EventHandler PropertyChanged;

        protected void OnPropertyChanged()
        {
            EventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, EventArgs.Empty);
        }

        [DefaultValue(Appearance.Normal)]
        public Appearance Appearance
        {
            get { return _Appearance; }
            set
            {
                _Appearance = value;
                OnPropertyChanged();
            }
        }

        [DefaultValue(true)]
        public bool AutoCheck
        {
            get { return _AutoCheck; }
            set
            {
                _AutoCheck = value;
                OnPropertyChanged();
            }
        }

        [DefaultValue(false)]
        public bool AutoEllipsis
        {
            get { return _AutoEllipsis; }
            set
            {
                _AutoEllipsis = value;
                OnPropertyChanged();
            }
        }

        [DefaultValue(false)]
        public bool AutoSize
        {
            get { return _AutoSize; }
            set
            {
                _AutoSize = true;
                OnPropertyChanged();
            }
        }

        [DefaultValue(ContentAlignment.MiddleLeft)]
        public ContentAlignment CheckAlign
        {
            get { return _CheckAlign; }
            set
            {
                _CheckAlign = value;
                OnPropertyChanged();
            }
        }

        [DefaultValue(typeof(Color), "")]
        public Color FlatAppearanceBorderColor
        {
            get { return _FlatAppearanceBorderColor; }
            set
            {
                _FlatAppearanceBorderColor = value;
                OnPropertyChanged();
            }
        }

        [DefaultValue(1)]
        public int FlatAppearanceBorderSize
        {
            get { return _FlatAppearanceBorderSize; }
            set { _FlatAppearanceBorderSize = value; OnPropertyChanged(); }
        }

        [DefaultValue(typeof(Color), "")]
        public Color FlatAppearanceCheckedBackColor
        {
            get { return _FlatAppearanceCheckedBackColor; }
            set
            {
                _FlatAppearanceCheckedBackColor = value;
                OnPropertyChanged();
            }
        }

        [DefaultValue(typeof(Color), "")]
        public Color FlatAppearanceMouseDownBackColor
        {
            get { return _FlatAppearanceMouseDownBackColor; }
            set
            {
                _FlatAppearanceMouseDownBackColor = value;
                OnPropertyChanged();
            }
        }

        [DefaultValue(typeof(Color), "")]
        public Color FlatAppearanceMouseOverBackColor
        {
            get { return _FlatAppearanceMouseOverBackColor; }
            set
            {
                _FlatAppearanceMouseOverBackColor = value;
                OnPropertyChanged();
            }
        }

        [DefaultValue(FlatStyle.Standard)]
        public FlatStyle FlatStyle
        {
            get { return _FlatStyle; }
            set
            {
                _FlatStyle = value;
                OnPropertyChanged();
            }
        }

        [DefaultValue(typeof(SystemColors), "ControlText")]
        public Color ForeColor
        {
            get { return _ForeColor; }
            set
            {
                _ForeColor = value;
                OnPropertyChanged();
            }
        }

        [DefaultValue(RightToLeft.No)]
        public RightToLeft RightToLeft
        {
            get { return _RightToLeft; }
            set
            {
                _RightToLeft = value;
                OnPropertyChanged();
            }
        }

        [DefaultValue(ContentAlignment.MiddleLeft)]
        public ContentAlignment TextAlign
        {
            get { return _TextAlign; }
            set
            {
                _TextAlign = value;
                OnPropertyChanged();
            }
        }

        [DefaultValue(false)]
        public bool ThreeState
        {
            get { return _ThreeState; }
            set
            {
                _ThreeState = value;
                OnPropertyChanged();
            }
        }
    }
}
