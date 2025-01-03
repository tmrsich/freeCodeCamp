// Fetch data
fetch('https://raw.githubusercontent.com/freeCodeCamp/ProjectReferenceData/master/GDP-data.json')
.then(response => response.json()) 
.then(data => {

// Chart dimensions
const width = 800;
const height = 400;
const padding = 40;

// Create SVG element
const svg = d3.select('#chart')
  .attr('width', width)
  .attr('height', height);

// X-axis scale
const xScale = d3.scaleBand()
  .domain(data.data.map(d => new Date(d[0]).getFullYear()))
  .range([padding, width - padding])

// X-axis tick values every 10 years
const xAxisTickValues = xScale.domain().filter((year, index) => index % 10 === 0);

// X-axis
const xAxis = d3.axisBottom(xScale)
  .tickValues(xAxisTickValues)
  .tickFormat(d3.format("d")); // Format as decimal without leading zeros
svg.append('g')
  .attr('transform', `translate(0, ${height - padding})`)
  .attr('id', 'x-axis')
  .call(xAxis)
  .selectAll("text")  // Select all text elements for customization
  .text(d => d);     // Display only the year

// Y-axis scale
const yScale = d3.scaleLinear()
  .domain([0, d3.max(data.data, d => d[1])])
  .range([height - padding, padding]);

// Y-axis
const yAxis = d3.axisLeft(yScale);
svg.append('g')
  .attr('transform', `translate(${padding}, 0)`)
  .attr('id', 'y-axis')
  .call(yAxis);
  
// Bars
svg.selectAll('.bar')
  .data(data.data)
  .enter().append('rect')
  .attr('class', 'bar')
  .attr('data-date', d => d[0])
  .attr('data-gdp', d => d[1])
  .attr('x', d => xScale(new Date(d[0]).getFullYear()))
  .attr('y', d => yScale(d[1]))
  .attr('width', xScale.bandwidth())
  .attr('height', d => height - padding - yScale(d[1]))
  .on('mouseover', d => {
    const tooltip = d3.select('#tooltip');
    tooltip.html(`<strong>Date:</strong> ${new Date(d[0]).getFullYear()}<br><strong>GDP:</strong> ${d[1]}`);
    tooltip.attr('data-date', d[0]);
    tooltip.style('left', (d3.event.pageX + 10) + 'px')
      .style('top', (d3.event.pageY - 28) + 'px')
      .style('display', 'block');
  })
  .on('mouseout', () => {
    d3.select('#tooltip').style('display', 'none');
  });
});