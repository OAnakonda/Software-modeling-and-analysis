
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Items : armorItems {

    public Items() {
    }

    public abstract int id;

    public abstract int cell-type;

    public void Attribute3;

    public abstract int rarity;

    /// <summary>
    /// @return
    /// </summary>
    public abstract void destroy() {
        // TODO implement here
        return null;
    }

}