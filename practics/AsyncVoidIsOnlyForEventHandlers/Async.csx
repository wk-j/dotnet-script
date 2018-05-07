static async void f() {
    await h();
}

static async Task g() {
    await h();
}

static async Task h() {
    throw new NotImplementedException();
}

//f();

g();