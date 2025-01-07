#include <iostream>

void one_a();
void one_b();
void one_c();
void two();
void three();
void four();


int main()
{
     one_a();
     one_b();
     one_c();
     two();
    three();
    four();    

    return 0;
}

unsigned long facrtorial(unsigned long n)
{
    if(n > 1){return n*facrtorial(n-1);} 
    else {return 1;}
}

void four()
{
    std::cout << "\nЗавдання 4. У крузі радіусом R навмання обирають точку. Визначити ймовірність того, що вона потрапить в одну із двох фігур, які не перетинаються і площі яких дорівнюють S1 та S2." << std::endl;
    const double PI = 3.14;
    double S,R = 13, S1 = 2.5, S2 = 0.57;
    S = PI * R * R;
    std::cout << (S1 + S2) / S << std::endl;  

}

void three()
{
    std::cout << "Завдання 3. У ліфт k-поверхового будинку сіло n пасажирів (n<k). Кожен незалежно від інших із однаковою ймовірністю може вийти на довільному (починаючи з другого) поверсі. Визначити ймовірність того, що:\n" << std::endl;
    unsigned long k = 6, n = 4;
    std::cout << "\nа) усі вийшли на різних поверхах." << std::endl;
    unsigned long m = facrtorial(k-1) / facrtorial(n);
    std::cout << m / 625.0 << std::endl;
    std::cout << "\n б) принаймні двоє вийшли на одному поверсі." << std::endl;
    std::cout << 1 - m / 625.0 << std::endl;


}

void two()
{
    unsigned long diff, n = 10, l = 4, m = 6, k =5;   
    std::cout << "Завдання 2. Серед n лотерейних білетів k виграшних. Навмання взяли m білетів. Визначити ймовірність того, що серед них l виграшних.\n" << std::endl;
    unsigned long a = facrtorial(n) / (facrtorial(m) *facrtorial(n-m));
    unsigned long b =(facrtorial(k) / (facrtorial(l) * facrtorial(k-l))) * (facrtorial(k) / (2 * facrtorial(k-2))) ;
    std::cout << a << std::endl;

    std::cout <<   b << std::endl;

    std::cout << "P(A) = " << b / static_cast<double>(a) << std::endl;
    std::cout << std::endl;

}

void one_a()
{
    const int N = 11; 

    std::cout << "Завдання 1. Підкидають два гральні кубики. Визначити ймовірність того, що: " << std::endl;
    std::cout << "\na) Сума точок не перевищує 11;" << std::endl;

    std::cout << "сума очок не перевищує 11, це: ";

    for (int i = 1; i <= 6; i++)
    {
        for (int j = 1; j <= 6; j++)
        {
            if (i + j <=N)std::cout << "(" << i << "," << j << "),"; 
        }
        
    }
    std::cout << std::endl;

}

void one_b()
{
    const int N = 11; 

     std::cout << "\nб) добуток очок не перевищує 11" << std::endl;

    for (int i = 1; i <= 6; i++)
    {
        for (int j = 1; j <= 6; j++)
        {
            if (i * j <= N)std::cout << "(" << i << "," << j << "),"; 
        }
        
    }
    std::cout << std::endl;
}

void one_c()
{
    const int N = 11; 

        std::cout << "\nв) добуток очок ділиться на 11 без залишку." << std::endl;

    for (int i = 1; i <= 6; i++)
    {
        for (int j = 1; j <= 6; j++)
        {
            if (i * j % N ==0)std::cout << "(" << i << "," << j << "),"; 
        }
        
    }
    std::cout << std::endl;   
}

