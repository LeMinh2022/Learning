const express = require('express');
const morgan = require('morgan');
const hbs  = require('express-handlebars');
const app = express();
const path = require('path');
const { extname } = require('path');
const port = 3000;

// add route
const route = require('./routes');

//midlerware
app.use(express.urlencoded({
  extended: true
}));
app.use(express.json());

// HTTP logger
// app.use(morgan('combined'))

// template engien 
app.engine('hbs', hbs.engine({extname: '.hbs'}));
app.set('view engine', 'hbs');
app.set('views', path.join(__dirname,'resources/views'));

// static link 
app.use(express.static(path.join(__dirname, 'public')));

// Routes init
route(app);

app.listen(port, () => {
  console.log(`Example app listening on port ${port}`)
})