import React, {Fragment} from "react";
import "./index.css"
import {Route, BrowserRouter, Routes} from "react-router-dom";
import { Home } from "./components/Home";
import { NavBar } from "./components/NavBar";

export default function App() {
  return (
    <BrowserRouter>
        <NavBar/>
        <Routes>
        <Route path="/" Component={Home}/>
        <Route path="/about" Component={About}/>
        <Route path="/contact" Component={Contact}/>
        </Routes>
     </BrowserRouter>
  );
}
/*
// Home Page
const Home = () => (
  <Fragment>
    <h1>Home</h1>
    <FakeText />
  </Fragment>
  );*/
// About Page
export const About = () => (
  <Fragment>
    <h1>About</h1>
    <FakeText />
  </Fragment>
  );
// Contact Page
const Contact = () => (
  <Fragment>
    <h1>Contact</h1>
    <FakeText />
  </Fragment>
  );

const FakeText = () => (
  <p>
  Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.
  </p>
  )