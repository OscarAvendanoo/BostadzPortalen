/*console.log("js startar")*/
window.setupSearchBoxTabs = () => {
    document.querySelectorAll('.searchbox-tabs .nav-link').forEach(tab => {
        tab.addEventListener('click', function (event) {
            event.preventDefault();
            const targetTab = this.getAttribute('data-tab');

            document.querySelectorAll('.tab-content').forEach(content => {
                content.style.display = 'none';
            });

            document.getElementById(targetTab).style.display = 'block';

            document.querySelectorAll('.searchbox-tabs .nav-link').forEach(link => {
                link.classList.remove('active');
            });
            this.classList.add('active');
        });
    });
};



//document.querySelectorAll('.searchbox-tabs .nav-link').forEach(tab => {
//    tab.addEventListener('click', function (event) {
//        event.preventDefault();
//        const targetTab = this.getAttribute('data-tab');

//        document.querySelectorAll('.tab-content').forEach(content => {
//            content.style.display = 'none';
//        });

//        document.getElementById(targetTab).style.display = 'block';

//        document.querySelectorAll('.searchbox-tabs .nav-link').forEach(link => {
//            link.classList.remove('active');
//        });
//        this.classList.add('active');
//    });
//});



//document.querySelectorAll('.nav-link').forEach(tab => {
//    tab.addEventListener('click', function (event) {
//        event.preventDefault(); // Förhindrar sidladdning
//        const targetTab = this.getAttribute('data-tab'); // Hämta målfiken

//        // Dölj alla innehåll
//        document.querySelectorAll('.tab-content').forEach(content => {
//            content.style.display = 'none';
//        });

//        // Visa rätt innehåll
//        document.getElementById(targetTab).style.display = 'block';

//        // Ändra aktiv flik
//        document.querySelectorAll('.nav-link').forEach(link => {
//            link.classList.remove('active');
//        });
//        this.classList.add('active');
//    });
//});