document.addEventListener('DOMContentLoaded', function () {
    const chart = Highcharts.chart('container', {
        chart: {
            type: 'bar'
        },
        title: {
            text: 'Complete %'
        },
        xAxis: {
            categories: ['Complete All Sample', 'Complete Male Sample', 'Complete Female Sample']
        },
        yAxis: {
            title: {
                text: 'Complete'
            }
        },
        series: [{
            name: 'Yes',
            data: [20, 30, 50]
        }
        // , {
        //     name: 'No',
        //     data: [80, 70, 50 ]
        // }
    ]
    });
});

// document.addEventListener('DOMContentLoaded', function () {
//     const chart = Highcharts.chart('container', {
//         chart: {
//             type: 'bar'
//         },
//         title: {
//             text: 'Fruit Consumption'
//         },
//         xAxis: {
//             categories: ['Apples', 'Bananas', 'Oranges']
//         },
//         yAxis: {
//             title: {
//                 text: 'Fruit eaten'
//             }
//         },
//         series: [{
//             name: 'Jane',
//             data: [1, 0, 4]
//         }, {
//             name: 'John',
//             data: [5, 7, 3]
//         }]
//     });
// });

// Highcharts.chart('container', {
//     chart: {
//       plotBackgroundColor: null,
//       plotBorderWidth: null,
//       plotShadow: false,
//       type: 'pie'
//     },
//     title: {
//       text: 'Browser market shares in January, 2018'
//     },
//     tooltip: {
//       pointFormat: '{series.name}: <b>{point.percentage:.1f}%</b>'
//     },
//     accessibility: {
//       point: {
//         valueSuffix: '%'
//       }
//     },
//     plotOptions: {
//       pie: {
//         allowPointSelect: true,
//         cursor: 'pointer',
//         dataLabels: {
//           enabled: false
//         },
//         showInLegend: true
//       }
//     },
//     series: [{
//       name: 'Brands',
//       colorByPoint: true,
//       data: [{
//         name: 'Chrome',
//         y: 61.41,
//         sliced: true,
//         selected: true
//       }, {
//         name: 'Internet Explorer',
//         y: 11.84
//       }, {
//         name: 'Firefox',
//         y: 10.85
//       }, {
//         name: 'Edge',
//         y: 4.67
//       }, {
//         name: 'Safari',
//         y: 4.18
//       }, {
//         name: 'Other',
//         y: 7.05
//       }]
//     }]
//   });