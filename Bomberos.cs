using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Bomberos
{
    #region Bomberos
    public class Bomberos
    {
        #region Member Variables
        protected string _BomberoEmp;
        #endregion
        #region Constructors
        public Bomberos() { }
        public Bomberos()
        {
        }
        #endregion
        #region Public Properties
        public virtual string BomberoEmp
        {
            get {return _BomberoEmp;}
            set {_BomberoEmp=value;}
        }
        #endregion
    }
    #endregion
}