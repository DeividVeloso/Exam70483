using System;

public static class EnumExample
{
    public static EnumExample()
    {
    }

    //public enum Days { Seg = 1, Ter, Quar, Quin, Sex, Sab, Dom};

    [Flags]
    public static enum Days
    {
        None = 0x0,
        Sunday = 0x1,
        Monday = 0x2,
        Tuesday = 0x4,
        Wednesday = 0x8,
        Thursday = 0x10,
        Friday = 0x20,
        Saturday = 0x40
    }
    Days readingDays = Days.Monday | Days.Saturda;
}
