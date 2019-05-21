using System;

namespace CBCode { 
 class Program { 
 static void Main()
{
 for ( double counter = 0 ; counter < 10 ; counter += + 1 ) {
 Console.WriteLine ( "ForLoop1" + counter ) ;
}
 double counter2 = 0 ;
for ( counter2 = 5 ; counter2 < 10 ; counter2 += + 1 ) {
 Console.WriteLine ( "ForLoop2" + counter2 ) ;
}
 if ( 2 < 3 ) {
 Console.WriteLine ( "If statement succeeded" ) ;
}
 else {
 Console.WriteLine ( "If statement failed" ) ;
}
 if ( 2 > 3 ) {
 Console.WriteLine ( "If statement failed" ) ;
}
 else {
 Console.WriteLine ( "If statement succeeded" ) ;
}
 double opq = 0 ;
while ( opq < 3 ) {
 Console.WriteLine ( "While statement entered" ) ;
opq += + 1 ;
}
 while ( opq < 0 ) {
 Console.WriteLine ( "While statement mistakenly entered" ) ;
}
 }
 
} 
} 
