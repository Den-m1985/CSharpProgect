
// програмка перестановки колец с башни на башню.
//Имеются 3 башни. На 1й count колец в порядке убывания от основания.
//Нужно переставить в таком же порядке на последнюю башню. 
void Towers(string with = "1", string on = "3", string some = "2", int count = 3)
{
    if (count >1) Towers(with,some, on, count -1);
    Console.WriteLine($"{with} >> {on}");
    if (count >1) Towers(some, on, with, count -1);
}

Towers();