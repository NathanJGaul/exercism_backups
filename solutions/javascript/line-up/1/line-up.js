//
// This is only a SKELETON file for the 'Line Up' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

export const format = (name, number) => {
  let post = '';
  let numStr = number.toString();
  if (numStr.endsWith("11") || numStr.endsWith("12") || numStr.endsWith("13")) {
    post = 'th';
  } else if (numStr.endsWith("1")) {
    post = 'st';
  } else if (numStr.endsWith("2")) {
    post = 'nd';
  } else if (numStr.endsWith("3")) {
    post = 'rd';
  } else {
    post = 'th';
  }
  
  return `${name}, you are the ${number}${post} customer we serve today. Thank you!`;
};
