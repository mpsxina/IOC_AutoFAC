using System;
using System.Collections.Generic;
using System.Text;
using Autofac;

namespace QueueServiceByAutofac
{
    public interface IPushServive
    {
        void Execute();
    }
    public class PushServive : IPushServive
    {
        public void Execute()
        {
            Console.WriteLine("An item is pushed in to the Queue.");
        }
    }

    public interface IPopService
    {
        void Execute();
    }

    public class PopService : IPopService
    {
        public void Execute()
        {
            Console.WriteLine("An item is pop out in to the Queue.");
        }
    }
    class QueueService
    {
        public IPushServive ObjPushSerivce = null;
        public IPopService ObjPopService = null;

        //injection through constructor  
        public QueueService(IPushServive tmpService)
        {
            ObjPushSerivce = tmpService;
        }
        //Injection through property  
        public IPopService SetPopService
        {
            set { ObjPopService = value; }
        }
        public void Process()
        {
            ObjPushSerivce.Execute();
            ObjPopService.Execute();
        }
    }
}
