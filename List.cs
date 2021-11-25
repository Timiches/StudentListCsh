using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace StudentList2
{
    public class List<InfType> : IEnumerable<InfType>, IComparable<List<InfType>>, ICloneable where InfType : IComparable<InfType>, new()
    {

        class Elem
        {
            private InfType inf;
            private Elem next;

            public InfType Inf
            {
                get { return inf; }
                set { inf = value; }
            }

            public Elem()
            {

            }

            public Elem Next
            {
                get { return next; }
                set { next = value; }
            }

            public Elem(InfType Inf, Elem Next) // нигде не используется
            {
                inf = Inf;
                next = Next;
            }

            public Elem(InfType Inf)
            {
                inf = ReferenceEquals(Inf as ValueType, null) ? (InfType)((ICloneable)Inf).Clone() : Inf;
            }
        }

        private Elem Tail, CurPosition;
        private uint Len;

        public uint ListLen 
        {
            get { return Len; }
        }

        int IComparable<List<InfType>>.CompareTo(List<InfType> value)
        {
            return Len > value.Len ? 1 : Len == value.Len ? 0 : -1;
        }

        public override bool Equals(object obj)
        {
            return (obj as List<InfType> == null) ? false : Len == ((List<InfType>)obj).Len;
        }

        public bool Equals(List<InfType> Val)
        {
            return ReferenceEquals(Val, null) ? false : Len == Val.Len;
        }

        public IEnumerator<InfType> GetEnumerator()
        {
            if (Tail != null)
            {
                Elem Cur = Tail.Next;
                do
                {
                    yield return Cur.Inf;
                    Cur = Cur.Next;
                } while (Cur != Tail.Next);

            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public object Clone()
        {
            List<InfType> NewList = new List<InfType>();

            if (Tail != null) 
            {
                Elem OldTemp = Tail;
                NewList.Tail = new Elem(Tail.Inf);
                Elem NewTemp = NewList.Tail;

                if (CurPosition != null) 
                {
                    while (OldTemp != CurPosition)
                    {
                        NewTemp.Next = new Elem(OldTemp.Next.Inf);
                        NewTemp = NewTemp.Next;
                        OldTemp = OldTemp.Next;
                    }
                    NewList.CurPosition = NewTemp;
                }

                while (OldTemp.Next != Tail)
                {
                    NewTemp.Next = new Elem(OldTemp.Next.Inf);
                    NewTemp = NewTemp.Next;
                    OldTemp = OldTemp.Next;
                }
                NewTemp.Next = NewList.Tail;
            }
            NewList.Len = ListLen;
            return NewList;
        }

        public List()
        {
            Tail = CurPosition = null;
        }

        public void AddBeginElem(InfType x)
        {
            if (x != null)
            {
                Elem NewElem = new Elem(x);
                if (Tail != null)
                    NewElem.Next = Tail.Next;
                else
                    Tail = NewElem;
                Tail.Next = NewElem;
                Len++;
            }
        }

        public void AddEndElem(InfType x)
        {
            if (x != null)
            {
                Elem NewElem = new Elem(x);
                if (Tail != null)
                    NewElem.Next = Tail.Next;
                else
                    Tail = NewElem; // IDK: вщзможно можно убрать.
                Tail.Next = NewElem;
                Tail = NewElem;
                Len++;
            }
        }

        public void AddSortedElement(InfType x)
        {
            if (Tail != null && x != null)
            {
                Elem NewElem = new Elem(x);
                if (Tail.Inf.CompareTo(x) < 0)
                {
                    NewElem.Next = Tail.Next;
                    Tail.Next = NewElem;
                    Tail = NewElem;
                    Len++;
                    return;
                }

                CurPosition = Tail;
                Elem Temp = Tail.Next;
                do
                {
                    Temp = Temp.Next;
                    CurPosition = CurPosition.Next;
                } while (Temp.Inf.CompareTo(x) < 0);
                NewElem.Next = Temp;
                CurPosition.Next = NewElem;
                Len++;
            }
        }

        public void SortCurElem()
        {
            if (CurPosition != null)
            {
                Elem Temp, PreTemp, PreCur;
                PreCur = PreTemp = Tail;
                Temp = Tail.Next;
                if (CurPosition.Inf.CompareTo(Temp.Inf) > 0)
                {
                    do
                    {
                        PreTemp = Temp;
                        Temp = Temp.Next;
                    } while (CurPosition.Inf.CompareTo(Temp.Inf) >= 0 && Temp != CurPosition);
                }
                if (Temp == CurPosition)
                {
                    PreCur = PreTemp;
                    do
                    {
                        PreTemp = Temp;
                        Temp = Temp.Next;
                    } while (CurPosition.Inf.CompareTo(Temp.Inf) >= 0 && PreTemp != Tail);
                }
                else
                {
                    while (Temp.Next != CurPosition)
                    {
                        Temp = Temp.Next;
                    }
                    PreCur = Temp;
                }
                if (PreTemp != CurPosition)
                {
                    PreCur.Next = CurPosition.Next;
                    CurPosition.Next = PreTemp.Next;
                    PreTemp.Next = CurPosition;
                    if (CurPosition.Inf.CompareTo(Temp.Inf) >= 0)
                        Tail = CurPosition;
                }
            }
        }

        public void Sort()
        {
            if (Tail != null)
            { // Существует ли список (точнее его хвост, как обязательный элемент)
                Elem Head = Tail.Next; //Обзываем следующий элемент от хвоста "головой"
                Elem Temp = Head;
                Tail.Next = null; // Разрываем кольцо
                MergeSort(ref Head); // Отправляем сортироватся
                while (Temp.Next != null)
                {
                    Temp = Temp.Next; //Идем по отсортированому списку
                } //пока не найдем хвост (пока существует элемент после Temp).
                Tail = Temp; //Нашли хвост (даем этому элементу звание "последний")
                Tail.Next = Head; //и закольцевали.
            }
        }

        private void MergeSort(ref Elem FirElemOfList)
        {
            Elem head = FirElemOfList, list1, list2;
            if (head == null || head.Next == null)
            { //Если пришел "массив" без или с одним элементом
                return; // то выходим из функции.
            }
            FindMid(head, out list1, out list2); //делим список
            MergeSort(ref list1);
            MergeSort(ref list2);
            FirElemOfList = MergeSubListSort(list1, list2);
        }

        private void FindMid(Elem head, out Elem list1, out Elem list2)
        { //Делит список пополам
            Elem Hare, Turtle;
            if (head == null || head.Next == null)
            { //Проверка на наличие всего одного элемента списка или его полное отсутсвие.
                list1 = head;
                list2 = null;
                return;
            }
            else
            {
                Turtle = head; //"Черепахе" присвоим первый элемент и она будет двигатся со скоростью а
                Hare = head.Next; // "Зайцу" присвоим второй элемент и он будет двигатся со скоростью 2а
                while (Hare != null)
                { // Пока заяц не добежит до конца ( пока не встанет на нулевой элемент). --Если условие срабатывает здесь, то список не четный--
                    Hare = Hare.Next;
                    if (Hare != null)
                    { //--Если условие срабатывает здесь, то список четный--
                        Turtle = Turtle.Next;
                        Hare = Hare.Next;
                    }
                }
                list1 = head; // Первый список начинается с головы
                list2 = Turtle.Next; // а второй список - со следующего элемента от черепахи (таким образом черепаха выступает разделителем)
                Turtle.Next = null; // и обрываем связь между этими двумя списками
            }
        }

        private Elem MergeSubListSort(Elem list1, Elem list2)
        {
            Elem TempHead = new Elem(); //временный список
            Elem Temp = TempHead;
            while (list1 != null && list2 != null)
            {
                if (list1.Inf.CompareTo(list2.Inf) >= 0)
                {
                    Temp.Next = list2;
                    Temp = list2;
                    list2 = list2.Next;
                }
                else
                {
                    Temp.Next = list1;
                    Temp = list1;
                    list1 = list1.Next;
                }
            }
            Temp.Next = list1 != null ? list1 : list2; //если один из списков закончился, то последующие элементы отсортированого списка будут остаткакми элементов другого списка(если существует список номер 1, то дальше будет он, если нет - то второй)
            return TempHead.Next;
        }

        public bool Find(InfType x)
        {
            if (Tail != null && x != null)
            {
                Elem Temp = Tail;
                do
                {
                    if (x.CompareTo(Temp.Inf) == 0)
                    {
                        CurPosition = Temp;
                        return true;
                    }
                    Temp = Temp.Next;
                } while (Temp != Tail);
            }
            CurPosition = null;
            return false;
        }

        public bool SetHead()
        {
            if (Tail != null)
            {
                CurPosition = Tail.Next;
                return true;
            }
            CurPosition = null;
            return false;
        }

        public bool SetTail()
        {
            CurPosition = Tail;
            return Tail == null;
        }

        public bool GetCurInf(ref InfType Inf)
        {
            if (CurPosition != null)
            {
                Inf = CurPosition.Inf;
                return true;
            }
            return false;
        }

        public bool SetCurInf(InfType Inf)
        {
            if (Inf != null && CurPosition != null)
            {
                CurPosition.Inf = Inf;
                return true;
            }
            return false;
        }

        public bool GetTail()
        {
            if (Tail != null)
                return true;
            return false;
        }

        public bool DelElem(InfType Inf)
        {
            if (Tail != null)
            {
                Elem Prev = Tail;
                Elem Temp = Tail.Next;
                do
                {
                    if (Temp.Inf.CompareTo(Inf) == 0)
                    {
                        if (Temp == Tail)
                        {
                            Tail = Tail.Next != Tail ? Prev : null;
                        }
                        Prev.Next = Temp.Next;
                        //delete Temp;
                        Len--;
                        return true;
                    }
                    Prev = Prev.Next;
                    Temp = Temp.Next;
                } while (Prev != Tail);
            }
            return false;
        }

        public bool DelCurElem()
        {
            if (Tail != null && CurPosition != null)
            {
                Elem Temp = CurPosition;
                do
                {
                    Temp = Temp.Next;
                } while (Temp.Next != CurPosition);
                Temp.Next = CurPosition.Next;

                if (CurPosition == Tail)
                {
                    if (Tail.Next == Tail)
                        Temp = null;
                    Tail = Temp;
                }
                //delete this.CurPosition;
                CurPosition = Temp;
                Len--;
                return true;
            }
            return false;
        }

        public void DelAll()
        {
            Tail = CurPosition = null;
            Len = 0;
        }

        public static List<InfType> operator ++(List<InfType> value)
        {
            if (ReferenceEquals(value, null) == false && value.CurPosition != null)
                value.CurPosition = value.CurPosition.Next;
            return value;
        }

        public static bool operator !(List<InfType> value) //И где это использовать?
        {
            return value.Tail != null;
        }

        protected void CopyFields(List<InfType> Src) //Для наследника
        {
            Tail = Src.Tail;
            Len = Src.Len;
            CurPosition = Src.CurPosition;
        }

    }

    public class UniversalList<InfType> : List<InfType>, IEnumerable<InfType>, IComparable<UniversalList<InfType>>, ICloneable where InfType : IComparable<InfType>, new()
    {
        private string caption;

        public string Caption 
        {
            get { return caption; }
            set { caption = value; }

        }

        public UniversalList(){
		    Caption = null;
	    }

        public UniversalList(string Caption) {
            this.Caption = Caption;
        }

        //SetTcharText ненужно
        //GetName ненужно

        private static int compare(UniversalList<InfType> First, UniversalList<InfType> Second)
        {
            return ReferenceEquals(First, Second) == false ? First is null == false ? Second is null == false ? string.Compare(First.Caption, Second.Caption) : 1  : -1  : 0;
        }

        public static bool operator ==(UniversalList<InfType> First, UniversalList<InfType> Second)
        {
            return compare(First, Second) == 0;
        }

        public static bool operator !=(UniversalList<InfType> First, UniversalList<InfType> Second)
        {
            return compare(First, Second) != 0;
        }

        public static bool operator >(UniversalList<InfType> First, UniversalList<InfType> Second)
        {
            return compare(First, Second) > 0;
        }

        public static bool operator >=(UniversalList<InfType> First, UniversalList<InfType> Second)
        {
            return compare(First, Second) >= 0;
        }

        public static bool operator <(UniversalList<InfType> First, UniversalList<InfType> Second)
        {
            return compare(First, Second) < 0;
        }

        public static bool operator <=(UniversalList<InfType> First, UniversalList<InfType> Second)
        {
            return compare(First, Second) <= 0;
        }

        int IComparable<UniversalList<InfType>>.CompareTo(UniversalList<InfType> other)
        {
            return compare(this, other);
        }

        //public bool Equals(UniversalList<InfType> value)
        //{
        //    return compare(Caption, value.Caption) == 0;
        //}

        public new object Clone()
        {
            UniversalList<InfType> NewList = new UniversalList<InfType>();
            NewList.CopyFields((List<InfType>)base.Clone());
            NewList.Caption = Caption;
            return NewList;
        }

        public override string ToString()
        {
            return Caption;
        }

    }

    public class ExamClass
    {
        private uint maxCount = 0;
        public virtual void textProc(ref byte[] textPart)
        {
            int length = textPart.Length;
            for (int i = 0; i < length; i++)
            {
                textPart[i] = (byte)(textPart[i] * 2 & 3);
            }
        }

        public virtual uint getCount(byte[] textPart, int length)
        {
            uint count = 0;
            for (int i = 0; i < length; i++)
            {
                count = count + (uint)(textPart[i] - (i % 10));
            }
            return count;
        }

        public virtual void getMaxCount(ref uint maxCount, uint currentCount)
        {
            if (maxCount < currentCount)
                maxCount = currentCount;
        }

        private async Task<int> asyncReadFromFile(string fileName, byte bufSize, ExamClass examClass) 
        {     
            byte[] buffer = new byte[bufSize];
            byte writedBytes = 0;
            if (!File.Exists(fileName))
                throw new FileNotFoundException("File not found");
            using (FileStream fStream = File.Open(fileName, FileMode.Open))
            {
                for (int i = byteText.Length - buffer.Length; i >= 0; i -= buffer.Length)
                {
                    await fStream.ReadAsync(buffer, 0, bufSize);
                    writedBytes = (byte)(writedBytes + bufSize);
                    textProc(ref buffer);
                    getMaxCount(ref examClass.maxCount, getCount(buffer, bufSize));
                }
            }
            return writedBytes;
        }
    }


    public class SomeClass2 
    {
        delegate byte processingFile(ref byte[] textPart);
        delegate uint getSomeCount(byte[] textPart, uint length);
        delegate void checkSumCount(ref uint finalCount, uint currentCount);
        uint finalCount = 0;
        private async void asyncWriteToFile(string inFileName, string outFileName, byte bufSize, processingFile pf, getSomeCount gsc, checkSumCount csc) 
        {
            if (!File.Exists(inFileName) || !File.Exists(outFileName))
                throw new FileNotFoundException("File not found");

            pf = (ref byte[] textPart) => 
            {
                //some kind of processing
                int length = textPart.Length;
                byte count = 0;
                for (int i = 0; i < length; i++) {
                    textPart[i] = (byte)(textPart[i] & 1);
                    count++;
                }
                return count;
            };

            gsc = (byte[] textPart, uint length) => 
            {
                uint count = 0;
                for (int i = 0; i < length; i++) {
                    count += (uint)(textPart[i] / 1);
                }
                return count;
            };

            csc = (ref uint finalCount, uint currentCount) =>
            {
                if (finalCount < currentCount)
                    finalCount = currentCount;
            };

            byte[] byteText = Encoding.ASCII.GetBytes(text);
            byte[] buffer = new byte[bufSize];
            using (FileStream outSourceStream = new FileStream(outFileName, FileMode.Create, FileAccess.Write, FileShare.None, bufferSize: bufSize, useAsync: true))
            using (FileStream inSourceStream = new FileStream(inFileName, FileMode.Open, FileAccess.Read, FileShare.Read, bufferSize: bufSize, useAsync: true))
            {
               
                for (int i = (int)fStream.Length - buffer.Length; i >= 0; i -= buffer.Length) {  //я не знаю, надо както в буфер записывать по кускам, а ка это сделать - не знаю
                    buffer = byteText;
                    pf(ref buffer);
                    uint curCount = gsc(buffer, 4096);
                    csc(ref finalCount, curCount);

                    await sourceStream.WriteAsync(buffer, 0, bufSize);
                }
                sourceStream.WriteByte((byte)finalCount);
            }
        }
    }


    public class SomeClassForFile
    {
        delegate byte processingFile(ref byte[] textPart);
        delegate uint getSomeCount(byte[] textPart, uint length);
        delegate void checkSumCount(ref uint finalCount, uint currentCount);
        uint finalCount = 0;
        uint writedBytesCount = 0;
        private async void asyncWriteToFile(string inFileName, string outFileName, byte bufSize, processingFile pf, getSomeCount gsc, checkSumCount csc)
        {
            if(!File.Exists(inFileName) || !File.Exists(outFileName))
                throw new FileNotFoundException("File not found");

            pf = (ref byte[] textPart) =>
            {
                int length = textPart.Length;
                byte count = 0;
                for (int i = 0; i < length; i++)
                {
                    textPart[i] = (byte)(textPart[i] & 1);
                    count++;
                }
                return count;
            };

            gsc = (byte[] textPart, uint length) =>
            {
                uint count = 0;
                for (int i = 0; i < length; i++)
                {
                    count = (uint)textPart.Length - length + 1;
                }
                return count;
            };

            csc = (ref uint finalCount, uint currentCount) =>
            {
                if (finalCount < currentCount)
                    finalCount = currentCount;
            };

            using (FileStream outSourceStream = new FileStream(outFileName, FileMode.Create, FileAccess.Write, FileShare.None, bufferSize: bufSize, useAsync: true))
            using (FileStream inSourceStream = new FileStream(inFileName, FileMode.Open, FileAccess.Read, FileShare.Read, bufferSize: bufSize, useAsync: true))
            {
                byte[] buffer = new byte[bufSize];
                int numRead;
                string text;
                while ((numRead = await inSourceStream.ReadAsync(buffer, 0, buffer.Length)) != 0)
                {
                    pf(ref buffer);
                    uint curCount = gsc(buffer, bufSize);
                    csc(ref finalCount, curCount);
                    writedBytesCount += bufSize; // return
                    await outSourceStream.WriteAsync(buffer, 0, bufSize);
                }
                outSourceStream.WriteByte((byte)finalCount);
            }
        }
    }


    public class FileWriter
    {
        delegate byte processingFile(ref byte[] textPart);
        private async void asyncWriteToFile(string fileName, string text, byte bufSize, processingFile processing) // по тз надо возвращать значение, но асинхронные методы могут быть только типа данных воид.
        {
            processing = (ref byte[] textPart) =>
            {
                //на самом деле не понятно как обрабатывать
                int length = textPart.Length;
                byte count = 0;
                for (int i = 0; i < length; i++)
                {
                    textPart[i] = (byte)(textPart[i] & 1);
                    count++;
                }
                return count;
            };

            byte[] byteText = Encoding.ASCII.GetBytes(text);
            byte[] buffer = new byte[bufSize];
            using (FileStream sourceStream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None, bufferSize: bufSize, useAsync: true))
            {
                try
                {
                    byte writedBytes = 0;
                    for (int i = byteText.Length - buffer.Length; i >= 0; i-= buffer.Length)
                    {  
                        buffer = byteText; // <== надо както в буфер записывать по кускам, а ка это сделать - не знаю
                        writedBytes += processing(ref buffer);
                        await sourceStream.WriteAsync(buffer, 0, bufSize);
                    }
                    //return writedBytes;
                }
                catch (FileNotFoundException e)
                {
                    Console.WriteLine(e.StackTrace);
                }
            }
        }

        private void syncWriteToFile(string fileName, string text, byte bufSize, processingFile processing) 
        {
            processing = (ref byte[] textPart) =>
            {
                int length = textPart.Length;
                byte count = 0;
                for (int i = 0; i < length; i++)
                {
                    textPart[i] = (byte)(textPart[i] & 1);
                    count++;
                }
                return count;
            };

            byte[] byteText = Encoding.ASCII.GetBytes(text);
            byte[] buffer = new byte[bufSize];
            using (FileStream sourceStream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None, bufferSize: bufSize, useAsync: false))
            {
                if (!File.Exists(fileName))
                    throw new FileNotFoundException();
                byte writedBytes = 0;
                for (int i = byteText.Length - buffer.Length; i >= 0; i -= buffer.Length)
                {
                    buffer = byteText;
                    writedBytes += processing(ref buffer);
                    sourceStream.Write(buffer, 0, bufSize);
                }
            }
        }
    }


    public interface ISomeInterface 
    {
        int GetVersion();
        int GetFieldsCount();
        bool GetFieldInfo(out byte[] fieldInfo, int fieldNumber);
    }

    public class SomeClass : ISomeInterface
    {
        int version = 1;
        string text;
        public bool GetFieldInfo(out byte[] fieldInfo, int fieldNumber)
        {
            
        }

        public int GetFieldsCount()
        {
            
        }

        public int GetVersion()
        {
            return version;
        }

        int saveToFile(string fileName, int bufSize, object someClass)
        {
            ISomeInterface someInterface = (ISomeInterface)someClass;
            if (!(someInterface is SomeClass))
                throw new InvalidCastException();
            if (!File.Exists(fileName))
                throw new FileNotFoundException("File not found");

            int writedBytes = 0;
            byte[] byteText;

            using (FileStream sourceStream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None, bufferSize: bufSize, useAsync: false))
            {
                int i = 0;
                while (someInterface.GetFieldInfo(out byteText, i))
                {
                    writedBytes += someInterface.GetFieldsCount();
                    sourceStream.Write(byteText, 0, bufSize);
                    i++;
                }
            }
            return writedBytes;
        }
    }
}
