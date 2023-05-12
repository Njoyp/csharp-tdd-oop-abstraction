using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_abstraction.CSharp.Main
{
    public class TodoItem {
        //private
        private string _title;
        private string _detail;
        private string _status;

        //methods
        public TodoItem(String title, String detail, String status)
        {
            this._title = title;
            this._detail = detail;
            this._status = status;
        }

        //properties
        public void setStatus(String status) {
            this._status = status;
        }

        public String getStatus() {
            return this._status;
        }
        public string Title { get { return _title; } set { _title=value; } }
        public string Detail { get { return _detail; } set { _detail=value; } }
        public string Status { get { return _status; } set { _status=value; } }
    }
}
