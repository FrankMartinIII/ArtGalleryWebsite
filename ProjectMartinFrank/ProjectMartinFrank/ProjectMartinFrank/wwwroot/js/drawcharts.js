google.charts.load('current', { packages: ['corechart'] });

function drawPieChart() {
    var data = new google.visualization.DataTable();
    data.addColumn('string', 'Category');
    data.addColumn('number', 'Value');
    var x = document.getElementById("generateData").innerHTML;
    x = x.trim();
    if (x.charAt(0) == ",") {
        x = x.substring(1);
    }

    var z = x.replace(/"/g, "!");
    x = z.replace(/'/g, "~");
    z = x.replace(/~/g, '"');
    x = z.replace(/!/g, "'");
    var chartData = JSON.parse("[" + x + "]");
    data.addRows(chartData);

    var options_pie = {
        title: '',
        width: 700, height: 700
    };

    var pie = new google.visualization.PieChart(document.getElementById('pieArea'));
    pie.draw(data, options_pie);

}