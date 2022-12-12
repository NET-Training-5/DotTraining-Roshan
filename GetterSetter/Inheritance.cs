class A{
    int x;


}
//single inheritance
class B: A //B inherits from A , B is of type A, Ais parent of B
{
    int y;
}
//multi level inheritance
public class C: B
{
    int z;
}

//multiple inheritance.... base class only 1 , interface as many as you like;

interface ID   //naming convention  starts with I;   
{

}

class E: B, ID
{

}