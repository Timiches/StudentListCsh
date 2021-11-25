using System;
using System.Collections.Generic;
using System.Text;

namespace StudentList2
{
    public class Student : IComparable<Student>, ICloneable
    {
        private string Name;
        private string SecName;
        private string MidName;
        private int BirthYear;
        private int MidMark;

        private const int MIN_BIRTH_YEAR = 1950, MAX_BIRTH_YEAR = 2020, MIN_MARK = 0, MAX_MARK = 100;

        public Student()
        {
            Name = SecName = MidName = "";
            BirthYear = MidMark = 0;
        }

        public Student(Student NewStudent)
        {
            Name = NewStudent.Name;
            SecName = NewStudent.SecName;
            MidName = NewStudent.MidName;
            BirthYear = NewStudent.BirthYear;
            MidMark = NewStudent.MidMark;
        }
        public Student(string Name, string SecName, string MidName, int BirthYear, int MidMark) {
            this.Name = Name;
            this.SecName = SecName;
            this.MidName = MidName;
            this.BirthYear = BirthYear;
            this.MidMark = MidMark;
        }

        public string name
        {
            get { return Name; }
            set { IsNotNull(ref Name, value); }
        }

        public string secName
        {
            get { return SecName; }
            set { IsNotNull(ref SecName, value); }
        }

        public string midName
        {
            get { return MidName; }
            set { IsNotNull(ref MidName, value); }
        }

        public int birthYear
        {
            get { return BirthYear; }
            set
            {
                if (MIN_BIRTH_YEAR < BirthYear && BirthYear < MAX_BIRTH_YEAR)
                    BirthYear = value;
            }
        }

        public int midMark
        {
            get { return MidMark; }
            set
            {
                if(MIN_MARK <= MidMark && MidMark <= MAX_MARK)
                    MidMark = value;
            }
        }

        private void IsNotNull(ref string Old, string New)
        {
            if (!ReferenceEquals(New, null))
                Old = New;
        }

        public static bool operator ==(Student St1, Student St2)
        {
            return compare(St1, St2) == 0;
        }

        public static bool operator !=(Student St1, Student St2)
        {
            return compare(St1, St2) != 0;
        }

        public static bool operator >(Student St1, Student St2)
        {
            return compare(St1, St2) > 0;
        }

        public static bool operator >=(Student St1, Student St2)
        {
            return compare(St1, St2) >= 0;
        }

        public static bool operator <(Student St1, Student St2)
        {
            return compare(St1, St2) < 0;
        }

        public static bool operator <=(Student St1, Student St2)
        {
            return compare(St1, St2) <= 0;
        }

        private static int compare(Student FirStud, Student SecStud)
        {
            if (ReferenceEquals(FirStud, SecStud) == false) // Страшно, ОЧЕНЬ СТРАШНО выглядит, но через тернарники не получилось (но можно както через инлайн функцию)
            {
                if (ReferenceEquals(FirStud, null) == false)
                {
                    if (ReferenceEquals(SecStud, null) == false)
                    {
                        int result = string.Compare(FirStud.SecName, SecStud.SecName);
                        if (result == 0)
                        {
                            result = string.Compare(FirStud.Name, SecStud.Name);
                            if (result == 0)
                            {
                                result = string.Compare(FirStud.MidName, SecStud.MidName);
                            }
                        }
                        return result;
                    }
                    return 1;
                }
                return -1;
            }
            return 0;
        }

        // Отето все снизу (Equals и GetHashCode) переопределяются т.к. стандартные версии этих методов значительно снижают производительность.

        // Механизм работы Equals таков: вызывается метод сравнения типа даных аргумента. Если тип данных object
        // то просто вызывается Equals. Если же нет, то проверяется, есть ли перегруженный метод с таким типом даных.
        // Если да, то вызывается перегруженый метод, а если нет - System.Object.Equals и далее принимаем правду/ложь.

        public override bool Equals(object obj)
        {
            return compare(this, obj as Student) == 0;
        }

        public bool Equals(Student St)
        {
            return compare(this, St) == 0;
        }

        public override int GetHashCode()
        {
            return StrHashCode(Name) ^ StrHashCode(SecName) ^ StrHashCode(MidName);
        }

        private int StrHashCode(string val)
        {
            if (!ReferenceEquals(val,null))
            {
                int num = 1238543, num2;

                for (int i = 0; i < val.Length; i += 4)
                {
                    num2 = val[i] << 16;
                    num = (num << 2) + num ^ num2;
                }

                return num ^ val.Length;
            }
            return 0;
        }

        public override string ToString() // форматированый вывод
        {
            return SecName + " " + Name + " " + MidName + " " + BirthYear + " " + MidMark;
        }

        int IComparable<Student>.CompareTo(Student other)
        {
            return compare(this, other);
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }	
}

