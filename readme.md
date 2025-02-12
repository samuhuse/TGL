
[<img src="https://tgl.co/assets/img/logo1.png" width="190" style="display:block;-webkit-filter: drop-shadow(1px 1px 0 black)drop-shadow(-1px -1px 0 black);filter:drop-shadow(1px 1px 0 black)drop-shadow(-1px -1px 0 black);" >](https://TGL.co/) 
> Your first Tgl project! 

## Overview

This project is a Blazor WebApp application that includes three main pages: <b>Posts</b>, <b>Products</b>, and <b>Departments</b>.<br />
Each page is designed to showcase different functionalities and components within the Blazor framework. 

This README outlines the purpose of each page, identifies current issues, and describes necessary enhancements to improve functionality and user experience.

## Pages

### 1. Posts Page

#### Description
The Posts page displays a list of posts. Currently, this page experiences slow load times due to the rendering of a large number of posts. 

#### Current Issues
- **Performance**: Initial page load is slow.
- **Styling**: The page requires better styling.

#### Enhancements Suggestions
- **Use Virtualize Component**: Implement the `Virtualize` component to improve page load times by only rendering posts in the viewport.
- **Optimization Techniques**: Explore additional optimizations such as server-side prerendering and more efficient data fetching strategies.

### 2. Products Page

#### Description
The Products page presents a grid of products. Users can click on a product to view more details in a modal. However, there are several functional and styling issues that need to be addressed.

#### Current Issues
- **Styling**: The grid requires better styling. Images are all different sizes. and the grid does not look visually appealing.
- **Pagination**: Pagination functionality is broken. 
- **Modal Display**: The modal shows the first product's details regardless of any product clicked.
- **Offline Availability**: The page is not accessible offline.

#### Enhancements Suggestions
- **Improve Styling**: Use `Products.razor.css` to enhance the appearance.
- **Fix Pagination**: Correct the pagination logic to ensure functionality.
- **Correct Modal Details**: Adjust modal functionality to display the correct product details and pass the right id to ProductDetails component.
- **Implement Offline Support**: Do not rely on SignalR. Can be achieved using WASM and/or Service Workers and caching strategies.

### 3. Departments Page

#### Description
This page lists departments in a table format, with navigation to a detailed view of each department and its employees. 
Another department can be added to the list by clicking the "Add Department" button. 

To be a valid department, it must have a name and an employee at least.<br/>
To be a valid employee, all fields are mandatory.


#### Current Issues
- **Interactivity**: The page lacks interactivity. The rows do not respond to user clicks and everything is static.
- **Navigation**: Incorrect routing from the department table to the DepartmentDetails page.
- **Parameter Handling**: The DepartmentDetails page does not process parameters correctly.
- **Validation**: The Add Department form does not include validation.
- **Add Employee**: The Add Employee button does not work.

#### Enhancements Suggestions
- **Add Interactivity**: Make the table rows clickable and navigate to the DepartmentDetails page.
- **Fix Routing**: Ensure proper routing with correct parameters to the DepartmentDetails page.
- **Parameter Handling**: Make sure that the DepartmentDetails page correctly processes the parameters to display accurate information.
- **Add Validation**: Implement all the required attributes with proper validation messages. Manage the form state and display validation errors under the corresponding fields.
- **Add Employee**: Implement both AddEmployee and DeleteEmployee functionalities on the corresponding buttons.

## Conclusion

There is a lot of potential for improvement in the Blazor TglTest project. <br/>
There are several issues that need to be addressed, and enhancements that can be made to improve the overall user experience. Feel free to follow the suggestions outlined above but also explore additional features and functionalities that can be added to make the application more engaging and user-friendly.

Is there anything else you would like to add to this project? Feel free to do so and make it your own!

Good luck and happy coding! 🚀

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE.txt) file for details.