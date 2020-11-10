using System;
using System.Collections.Generic;
using System.Text;

namespace Moj_Nowy_Dom
{
    class OutSide:Location
    {
        private bool hot;

       

        public OutSide(bool hot,string nazwa):base(nazwa) { this.hot = hot; }
        public override string Description { get { string NewDesription = base.Description;
                if (hot)
                    NewDesription += " Tutaj jest bardzo gorąco";
                return NewDesription;
            } }
    }
}
