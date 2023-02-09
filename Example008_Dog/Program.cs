int velocityMen_1 = 1;
int velocityMen_2 = 2;
int velocityDog = 5;
double distance = 10000;
int stopProg = 10;
int step = 0;
double time = distance / (velocityDog - velocityMen_1);
double distanceMen_2 = time * velocityMen_2;
double distanceMen_1 = time * velocityMen_1;
distance = distance + distanceMen_1 - distanceMen_2;
step++;

while (distance > stopProg)
{
    step++;
    time = distance / (velocityDog + velocityMen_2);
    distanceMen_2 = time * velocityMen_2;
    distanceMen_1 = time * velocityMen_1;
    distance = distance + distanceMen_1 - distanceMen_2;

    if (distance > stopProg)
    {
        step++;
        time = distance / (velocityDog - velocityMen_1);
        distanceMen_2 = time * velocityMen_2;
        distanceMen_1 = time * velocityMen_1;
        distance = distance + distanceMen_1 - distanceMen_2;

    }
}

Console.Write("Собака пробежит от одного к другому: ");
Console.Write(step);
Console.WriteLine(" раз.");