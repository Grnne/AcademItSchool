namespace Apartments
{
    internal class Apartments
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество этажей: ");
            int floorsAmount = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите количество подъездов: ");
            int entrancesAmount = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите номер квартиры: ");
            int apartmentNumber = Convert.ToInt32(Console.ReadLine());

            int apartmentsAmountPerFloor = 4;

            if (apartmentNumber <= 0 || apartmentNumber > floorsAmount * entrancesAmount * apartmentsAmountPerFloor)
            {
                Console.WriteLine("Квартира за пределами дома");
            }
            else
            {
                int apartmentsAmountPerEntrance = apartmentsAmountPerFloor * floorsAmount;
                int entranceNumber = (apartmentNumber - 1) / (apartmentsAmountPerFloor * floorsAmount) + 1;
                int floorNumber = (apartmentNumber - 1) % apartmentsAmountPerEntrance / apartmentsAmountPerFloor + 1;

                int apartmentPositionNumber = apartmentNumber % apartmentsAmountPerFloor;
                string apartmentPositionString;

                switch (apartmentPositionNumber)
                {
                    case 1:
                        apartmentPositionString = "ближняя слева";
                        break;
                    case 2:
                        apartmentPositionString = "дальняя слева";
                        break;
                    case 3:
                        apartmentPositionString = "дальняя справа";
                        break;
                    default:
                        apartmentPositionString = "ближняя справа";
                        break;
                }

                Console.WriteLine($"Подъезд: {entranceNumber}, этаж: {floorNumber}, позиция квартиры {apartmentPositionString}.");
            }
        }
    }
}