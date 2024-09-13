function updateBookColors() {
    console.log("Updating colors");  // logging to check the function gets called
    let containers = document.querySelectorAll(".book");

    containers.forEach(container => {
        let img = container.querySelector("img");
        if (img && img.complete) {
            let color = getMostProminentColor(img);
            container.style.backgroundColor = color;
        } else if (img) {
            img.onload = function () {
                let color = getMostProminentColor(img);
                container.style.backgroundColor = color;
            };
        }
    });
}

function getMostProminentColor(img) {
    let canvas = document.createElement("canvas");
    canvas.width = img.width;
    canvas.height = img.height;

    let ctx = canvas.getContext("2d");
    ctx.drawImage(img, 0, 0, img.width, img.height);

    let data = ctx.getImageData(0, 0, img.width, img.height).data;
    let colorCount = {};

    // Sample every 10th pixel for performance
    for (let i = 0; i < data.length; i += 40) {
        let red = data[i];
        let green = data[i + 1];
        let blue = data[i + 2];
        let alpha = data[i + 3];

        if (alpha === 255) {  // Ignore transparent pixels
            let key = `${red},${green},${blue}`;
            colorCount[key] = (colorCount[key] || 0) + 1;
        }
    }

    let mostProminent = Object.keys(colorCount).reduce((a, b) => colorCount[a] > colorCount[b] ? a : b);

    return `rgba(${mostProminent}, 0.20)`;
}
