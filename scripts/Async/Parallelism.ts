function asyncFunc1() {
    console.log("1");
    return 0;
}

function asyncFunc2() {
    console.log("2");
    return 1;
}

async function foo() {
    const rs1 = await asyncFunc1();
    const rs2 = await asyncFunc2();
}

async function foo2() {
    const [rs1, rs2, ...rest] = await Promise.all([
        asyncFunc1(),
        asyncFunc1(),
        asyncFunc1(),
        asyncFunc1(),
        asyncFunc1(),
        asyncFunc1(),
        asyncFunc1(),
        asyncFunc1(),
        asyncFunc1(),
        asyncFunc2(),
        asyncFunc2(),
        asyncFunc2(),
        asyncFunc2(),
        asyncFunc2(),
        asyncFunc2(),
        asyncFunc2(),
        asyncFunc2(),
        asyncFunc2(),
        asyncFunc2(),
        asyncFunc2(),
        asyncFunc2(),
        asyncFunc2(),
        asyncFunc2(),
        asyncFunc2(),
        asyncFunc2(),
        asyncFunc2(),
        asyncFunc2(),
        asyncFunc2(),
        asyncFunc2(),
    ]);
    console.log(rs1);
    console.log(rs2);
}

foo2();
