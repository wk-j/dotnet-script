

class Component {

    constructor() {
        this.click2.bind(this);
    }

    click2(e) { }

    click = (data) => (e) => {

    }

    render() {
        <div>
            <button click={this.click(100)} />
            <button click={this.click2(100)} />
            <button click={(e) => this.click(100)(e)} />
        </div>
    }
}


