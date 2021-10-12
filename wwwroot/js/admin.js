async function fetchSubjectsOfCategory(categoryId) {
    let result;
    if (categoryId) {
        result = await fetch("https://localhost:44360/api/CategorySubjectsRest?categoryId=" + categoryId);
    }
    else {
        result = await fetch("https://localhost:44360/api/CategorySubjectsRest");
    }

    let subjects = await result.json();
    console.log(subjects);
    return subjects;
}

async function loadOtherSubjects(categoryId) {
    let result = await fetch("https://localhost:44360/api/CategorySubjectsRest/otherSubjects?categoryId=" + categoryId);

    result.json().then((res, rej) => console.log(res)).catch((err) => console.log(err));
    //let subjects = await result.json();

    var other = document.getElementById("other-categories");

    console.log("loadOther " + subjects.length);
    for (let key in subjects) {
        let option = document.createElement("option");
        option.text = subjects[key].name;
        option.value = subjects[key].id;
        other.add(option);
    }
}

async function addSubjectCategory() {
    event.preventDefault();
    var c = document.getElementById("other-categories");

    const selected = document.querySelectorAll('#other-categories option:checked');
    const values = Array.from(selected).map(el => el.value);

    console.log(values);
    console.log("submited");
}

async function deleteSubject(btn, subjectId) {
    var confirm = window.confirm("Are you sure you want to delete subject from category?");
    if (confirm) {
        console.log(subjectId);
        let result = await fetch("https://localhost:44360/api/CategorySubjectsRest/" + subjectId,
            {
                method: "DELETE"
            }
        );
        
        //let subjects = await result.json();
        if (result.status === 200) {
            var row = btn.parentNode.parentNode;
            console.log(btn);
            row.parentNode.removeChild(row);
        } else {
            alert("Something went wrong! Maybe books are in this subject??");
        }

    }
}

async function fetchCategories(categoryIdOfCurrentBook) {
    console.log(categoryIdOfCurrentBook);
    let result = await fetch("https://localhost:44360/api/CategorySubjectsRest/categories");
    let categories = await result.json();

    console.log(categories);
    let catsSelect = document.getElementById("categories");

    for (let key in categories) {
        let option = document.createElement("option");
        option.text = categories[key].name;
        option.value = categories[key].id;
        console.log("cate " + categories[key].id);
        if (categories[key].id === categoryIdOfCurrentBook) option.selected = "selected";
        catsSelect.add(option);
    }

    //handle kur ndrrohet value i selectit me category
    catsSelect.onchange = async () => {
        console.log("changed");
        let catsSelect = document.getElementById("categories");
        console.log(catsSelect.value);

        let subjectsSelect = document.getElementById("category-subjects");
        while (subjectsSelect.firstChild) {
            subjectsSelect.removeChild(subjectsSelect.firstChild);
        }

        let subjectsInCategory = await fetchSubjectsOfCategory(catsSelect.value);
        for (let key in subjectsInCategory) {
            let option = document.createElement("option");
            option.text = subjectsInCategory[key].name;
            option.value = subjectsInCategory[key].id;

            if (subjectsInCategory[key].id === categoryIdOfCurrentBook) option.selected = "selected";
            subjectsSelect.add(option);
        }
        console.log(subjectsInCategory);
    }

    catsSelect.onchange();
}
