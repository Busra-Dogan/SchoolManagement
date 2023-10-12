using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using SchoolManagement.Business.Abstract;
using SchoolManagement.Business.Concrete;
using SchoolManagement.Core.Utilities.Interceptors;
using SchoolManagement.DataAccess.Abstract;
using SchoolManagement.DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Business.DependencyResolves.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ClassManager>().As<IClassService>().SingleInstance();
            builder.RegisterType<EfClass>().As<IClass>().SingleInstance();

            builder.RegisterType<ParameterManager>().As<IParameterService>();
            builder.RegisterType<EfParameter>().As<IParameter>();

            builder.RegisterType<StudentManager>().As<IStudentService>().SingleInstance();
            builder.RegisterType<EfStudent>().As<IStudent>().SingleInstance();

            //builder.RegisterType<UserManager>().As<IUserService>();
            //builder.RegisterType<EfUserDal>().As<IUserDal>();

            //builder.RegisterType<AuthManager>().As<IAuthService>();
            //builder.RegisterType<JwtHelper>().As<ITokenHelper>();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
