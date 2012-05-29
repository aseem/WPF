using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContactManager.Presenters
{
    public class PresenterBase<T> : Notifier
    {
        private readonly string _tabHeaderPath;
        private readonly T _view;
        
        public PresenterBase(T view)
        {
            _view = view;
        }
        
        public PresenterBase(T view, string tabHeaderPath)
        {
            _view = view;
            _tabHeaderPath = tabHeaderPath;
        }
        
        public T View
        {
            get { return _view; }
        }
        
        public string TabHeaderPath
        {
            get { return _tabHeaderPath; }
        }
    }
}
