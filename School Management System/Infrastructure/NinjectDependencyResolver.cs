using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ninject;
using SchoolManagementSystem.Domain.Abstract;
using SchoolManagementSystem.Domain.Concrete;

namespace School_Management_System.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;
        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }
        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }
        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);


        }
        private void AddBindings()
        {
            kernel.Bind<IStudentRepository>().To<EFStudentRepository>();
            kernel.Bind<IStaffRepository>().To<EFStaffRepository>();
            kernel.Bind<ISchedulesRepository>().To<EFSchedulesRepository>();
            kernel.Bind<ICoursesRepository>().To<EFCoursesRepository>();
            kernel.Bind<ISubjectsRepository>().To<EFSubjectsRepository>();
            kernel.Bind<ITransactionsRepository>().To<EFTransactionsRepository>();
            //kernel.Bind<IOrderRepository>().To<EFOrderRepository>();
            //kernel.Bind<IInvoiceRepository>().To<EFInvoiceRepository>();
        }
    }
}