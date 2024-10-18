#include <iostream>

struct myFrac
{
    long long t_nom,t_denom;// data type long in c# = long long in c++
    myFrac(long long nom, long long denom) : t_nom(abs(nom)), t_denom(abs(denom))
    {
        while(nom!=denom)(nom>denom)? nom-=denom : denom-=nom;
    }
    std::string ToString() {return "(" + std::to_string(t_nom) + "/" + std::to_string(t_denom) + ")";}

};

std::string ToStringWithIntPart(myFrac f)
{

}

double DoubleValue(myFrac f)
{

}

myFrac Plus(myFrac f)
{

}

myFrac Minus(myFrac f1, myFrac f2)
{

}

myFrac Multiply(myFrac f1, myFrac f2)
{

}

myFrac Divide(myFrac f1, myFrac f2)
{

}

myFrac calcExpr1(int n)
{

}

myFrac calcExpr2(int n)
{

}



int main()
{

    return 0;
}