using System;
using static CovarianceAndContravariance.Delegates;

namespace CovarianceAndContravariance
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowCovariance();
            Console.WriteLine();
            ShowContravariance();
        }

        static void ShowCovariance()
        {
            Console.WriteLine("#Covariance#");
            Factory<Person> personfactory = CreatePerson;
            Factory<Person> covariancePersonFactory = CreateClient;
            Factory<Client> clientFactory = CreateClient;

            Client client = clientFactory.Invoke("Client");
            Person person = personfactory.Invoke("Person");

            Person covarianceClient = covariancePersonFactory.Invoke("covarianceClient");

            client.Display();
            person.Display();
            covarianceClient.Display();

            clientFactory = CreateCoolerClient;
            Client cc = clientFactory.Invoke("Tom");
            cc.Display();
        }

        static void ShowContravariance()
        {
            Console.WriteLine("#Contravariance#");
            Client cl = new Client("Tom");
            Person p = new Person("Alice");
            CoolerClient cc = new CoolerClient("Kate");

            ShowInfo<Client> showClientInfo = ShowClientName;
            ShowInfo<CoolerClient> showCoolerClientInfo = ShowCoolerClientName;

            showClientInfo.Invoke(cl);
            showCoolerClientInfo.Invoke(cc);
            showClientInfo = ShowPersonName;
            showClientInfo.Invoke(cl);

            showCoolerClientInfo = ShowPersonName;
            showCoolerClientInfo.Invoke(cc);


        
        }

    }
}
