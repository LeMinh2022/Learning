const express = require('express');
const morgan = require('morgan');
const hbs  = require('express-handlebars');
const app = express();
const path = require('path');
const { extname } = require('path');
const port = 3000;

// HTTP logger
// app.use(morgan('combined'))

// template engien 
app.engine('hbs', hbs.engine({extname: '.hbs'}));
app.set('view engine', 'hbs');
app.set('views', path.join(__dirname,'resources/views'))

// static link 
app.use(express.static(path.join(__dirname, 'public')))

app.get('/', (req, res) => {
  res.render('home');
});

app.get('/search', (req, res) => {
  console.log(req.query)
  res.render('search');
});

app.get('/news', (req, res) => {
  console.log(req.query.q)
  res.render('news');
});

app.post('/search', (req, res) => {
  console.log(req.query)
  res.render('search');
});

app.listen(port, () => {
  console.log(`Example app listening on port ${port}`)
})