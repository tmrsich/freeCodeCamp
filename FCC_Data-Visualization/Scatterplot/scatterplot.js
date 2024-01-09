const url="https://raw.githubusercontent.com/freeCodeCamp/ProjectReferenceData/master/cyclist-data.json"

// Defines variables
var pos = {
  padding: 20
}

var w = 1000 - pos.padding
var h = 600 - pos.padding

//Fetch data
fetch(url)
  .then(response => response.json())
  .then(data => {
    console.log(data)

    /* 
      xScale that scales linearly by year, with a:
        data domain that goes from the minimum year value in the dataset to the maximum year value
        data range (what will be displayed on the actual axis)
    */
    var xScale = d3.scaleLinear()
      .domain([
        d3.min(data, (d) => {
          return d.Year - 1;
        }),
        d3.max(data, (d) => {
          return d.Year + 1;
        })
      ])
      .range([pos.padding, w - pos.padding])

    var yScale = d3.scaleTime()
      .domain([
        d3.extent(data, (d) => {
          return d.Time
        })
      ])
      .range([0, h])

    var xAxis = d3.axisBottom(xScale).tickFormat(d3.format('d'));
    var yAxis = d3.axisLeft(yScale).tickFormat(d3.timeFormat("%M:%S"));

    var svg = d3
      .select("body")
      .append("svg")
      .attr("width", w + pos.padding)
      .attr("height", h + pos.padding)
      .style("border", "1px solid black")

    svg
      .append("g")
      .attr("class", "x axis")
      .attr("id", "x-axis")
      .attr("transform", "translate(0, " + h + ")")
      .call(xAxis)

    svg
      .append("g")
      .attr("class", "y axis")
      .attr("id", "y-axis")
      .attr("transform", "translate(26, 0)")
      .call(yAxis)

    


  });