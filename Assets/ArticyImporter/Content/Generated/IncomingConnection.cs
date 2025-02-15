//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Articy.Unity;
using Articy.Unity.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Articy.Articyproject_unitydrill2
{
    
    
    [Serializable()]
    public class IncomingConnection : IArticyBaseObject, IIncomingConnection, IObjectWithColor
    {
        
        [SerializeField()]
        private ArticyValueArticyString mLabel = new ArticyValueArticyString();
        
        [SerializeField()]
        private Color mColor;
        
        [SerializeField()]
        private UInt64 mSourcePin;
        
        [SerializeField()]
        private ArticyValueArticyObject mSource = new ArticyValueArticyObject();
        
        public ArticyString Label
        {
            get
            {
                return mLabel.GetValue();
            }
            set
            {
                mLabel.SetValue(value);
            }
        }
        
        public Color Color
        {
            get
            {
                return mColor;
            }
            set
            {
                mColor = value;
            }
        }
        
        public UInt64 SourcePin
        {
            get
            {
                return mSourcePin;
            }
            set
            {
                mSourcePin = value;
            }
        }
        
        public ArticyObject Source
        {
            get
            {
                return mSource.GetValue();
            }
            set
            {
                mSource.SetValue(value);
            }
        }
        
        private void CloneProperties(object aClone, Articy.Unity.ArticyObject aFirstClassParent)
        {
            IncomingConnection newClone = ((IncomingConnection)(aClone));
            if ((mLabel != null))
            {
                newClone.mLabel = ((ArticyValueArticyString)(mLabel.CloneObject(newClone, aFirstClassParent)));
            }
            newClone.Color = Color;
            newClone.SourcePin = SourcePin;
            if ((mSource != null))
            {
                newClone.mSource = ((ArticyValueArticyObject)(mSource.CloneObject(newClone, aFirstClassParent)));
            }
        }
        
        public object CloneObject(object aParent, Articy.Unity.ArticyObject aFirstClassParent)
        {
            IncomingConnection clone = new IncomingConnection();
            CloneProperties(clone, aFirstClassParent);
            return clone;
        }
    }
}
