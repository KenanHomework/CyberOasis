let selectContainer = document.querySelector(".select-container");
let select = document.querySelector(".select");
let input = document.getElementById("input");
let options = document.querySelectorAll(".select-container .option");

select.onclick = () => {
    selectContainer.classList.toggle("active");
};

options.forEach((e) => {
    e.addEventListener("click", () => {
        input.value = e.innerText;
        selectContainer.classList.remove("active");
        options.forEach((e) => {
            e.classList.remove("selected");
        });
        e.classList.add("selected");
    });
});

$('#summernote').summernote({
    fontNames: ["Source Code Pro", "sans-serif"],
    addDefaultFonts: false,
    placeholder: 'Hello',
    tabsize: 2,
    height: 300,
    toolbar: [
        // [groupName, [list of button]]
        ['style', ['bold', 'italic', 'underline', 'clear']],
        ['font', ['strikethrough', 'superscript', 'subscript']],
        ['fontsize', ['fontsize']],
        ['color', ['color']],
        ['para', ['ul', 'ol', 'paragraph']],
        ['height', ['height']],
        ['insert', ['link', 'table']],
    ]
});