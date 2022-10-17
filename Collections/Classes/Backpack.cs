using System;
using System.Collections;
using System.Collections.Generic;
using Collections.Interfaces;
using Collections.Classes;

namespace Collections.Classes{
    class Backpack<T> : Book, IBag<T>{
        T[] items = new T[5];
        int count;
    public override string Title { get; set; }
    public override string Author { get; set; } 
        public void Pack(T item){
            if(count == items.Length){
                Array.Resize(ref items, items.Length * 2);
            }
            items[count++] = item;
        } 
        
        public IEnumerator<T> GetEnumerator(){
            for(int i = 0; i < count; i++){
                yield return items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator(){
            return GetEnumerator();
        }

        public T Unpack(int index){
            Title.Remove(index);
             return Unpack(index);
            
        }
         
    }
}