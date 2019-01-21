namespace StudyEntityFramework2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<StudyEntityFramework2.BlogggingContext>
    {
        public Configuration()
        {
            //��ȡ������ָʾǨ�����ݿ�ʱ�Ƿ��ʹ���Զ�Ǩ�ƣ�Ĭ��ΪFalse����ʱ���������Ϊture�ſ�������
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(StudyEntityFramework2.BlogggingContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
