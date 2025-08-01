function varconcept() {
    var x = 5;
    console.log(x);
    var x = 25; //redecalaration is possible
    var x = "AAA"; //reassigning is also possible
    console.log(x);
}
//let
function Concepts() {
    let x = 25;
    if (x == 25) {
        let y = 10;
        console.log(y);
       y = 100;  //updation is possible, reassigning
     //   let y = 50; // redeclaration not possible
        console.log(y);
    }
}
function letconcepts() {
   // console.log(y1); //block scope hence cannot be referred outside the scope erroe : not defined
    let y1 = 6; //cannot access
    console.log(y1);
    //suitable for loops
    for (let i = 0; i < 5; i++) {
        console.log(i);
    }

    //with objects
    let { name, age } = { name: "Infinite Ltd.", age: 20 }
    console.log(name, age);
}

    //const
function constantconcepts() {
    const c ='a'; // missing initializer syntax error
    const c1 = 10;
    console.log(c, c1);
    //const with objects and arrays
    const cobj = { name: "Infinite Ltd." };
    console.log(cobj.name);
    cobj.name = "New Infinite Ltd.";
    console.log(cobj.name);


    const carr = [2, 4, 6, 8];
    carr.push(10);
    console.log(carr); //will display [2,4,6,8,10]
}

    //global variables

    let name = "Dhoni" // global variable
    function myfunction()
    {
       let color = 'Red'; // considered global
        console.log(typeof name + " " + "Cricketer name is " + name + " color " + color);
         color = 'Blue'; //local variable
    }

    //operators

    console.log(15 > 10);  //true
    console.log(15 == "15"); //true
    console.log(15 === "15"); //false

    //bitwise operators
    //&  bitwise and
    // | bitwise or
    // ^ bitwise Xor
    // ~ bitwise Not

    //ternary operator
    function ternary() {
    const age = 18;
    const righttovote = age >= 18 ? "Yes Adult" : "No Minor";
    console.log(righttovote);
    console.log(name);
}